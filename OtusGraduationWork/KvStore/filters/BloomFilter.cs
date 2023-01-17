using System;
using System.Collections;
using System.IO;
using System.Text;

namespace OtusGraduationWork.KvStore.filters
{
    public sealed class BloomFilter
	{
		private readonly int _hashFunctionCount;
		private readonly BitArray _hashBits;

		private BloomFilter(int hashFunctionCount, BitArray hashBits)
        {
			_hashFunctionCount = hashFunctionCount;
			_hashBits = hashBits;
        }

		public BloomFilter(int capacity)
		{
			// validate the params are in range
			if (capacity < 1)
			{
				throw new ArgumentOutOfRangeException("capacity", capacity, "capacity must be > 0");
			}

			//params
			var errorRate = BestErrorRate(capacity);
			var m = BestM(capacity, errorRate);
			var k = BestK(capacity, errorRate);

			this._hashFunctionCount = k;
			this._hashBits = new BitArray(m);
		}

		public void Add(string item)
		{
			if (item == null)
				throw new ArgumentNullException("item");

			var primaryHash = item.GetHashCode();
			var secondaryHash = HashString(item);

			for (int i = 0; i < _hashFunctionCount; i++)
			{
				var hash = ComputeHash(primaryHash, secondaryHash, i);
				_hashBits[hash] = true;
			}
		}

		public bool Contains(string item)
		{
			if (item == null)
				throw new ArgumentNullException("item");

			var primaryHash = item.GetHashCode();
			var secondaryHash = HashString(item);

			for (int i = 0; i < _hashFunctionCount; i++)
			{
				var hash = ComputeHash(primaryHash, secondaryHash, i);
				if (_hashBits[hash] == false)
				{
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Hashes a string using Bob Jenkin's "One At A Time" method from Dr. Dobbs (http://burtleburtle.net/bob/hash/doobs.html).
		/// Runtime is suggested to be 9x+9, where x = input.Length. 
		/// </summary>
		/// <param name="input">The string to hash.</param>
		/// <returns>The hashed result.</returns>
		private static int HashString(string input)
		{
			var hash = 0;

			for (int i = 0; i < input.Length; i++)
			{
				hash += input[i];
				hash += (hash << 10);
				hash ^= (hash >> 6);
			}

			hash += (hash << 3);
			hash ^= (hash >> 11);
			hash += (hash << 15);
			return hash;
		}

		private static int BestK(int capacity, float errorRate)
		{
			return (int)Math.Round(Math.Log(2.0) * BestM(capacity, errorRate) / capacity);
		}

		private static int BestM(int capacity, float errorRate)
		{
			return (int)Math.Ceiling(capacity * Math.Log(errorRate, (1.0 / Math.Pow(2, Math.Log(2.0)))));
		}

		private static float BestErrorRate(int capacity)
		{
			float c = (float)(1.0 / capacity);
			if (c != 0)
			{
				return c;
			}
			return (float)Math.Pow(0.6185, int.MaxValue / capacity);
		}


		/// <summary>
		/// Performs Dillinger and Manolios double hashing. 
		/// </summary>
		/// <param name="primaryHash"> The primary hash. </param>
		/// <param name="secondaryHash"> The secondary hash. </param>
		/// <param name="i"> The i. </param>
		/// <returns> The <see cref="int"/>. </returns>
		private int ComputeHash(int primaryHash, int secondaryHash, int i)
		{
			int resultingHash = (primaryHash + (i * secondaryHash)) % _hashBits.Count;
			return Math.Abs((int)resultingHash);
		}

		public void Write(Stream stream)
		{
			using (var writer = new BinaryWriter(stream, Encoding.UTF8, true))
			{
				writer.Write(_hashFunctionCount);
				writer.Write(_hashBits.Count);
				for (int i = 0; i < _hashBits.Count; i++)
				{
					writer.Write(_hashBits[i] ? (byte)0x01 : (byte)0x00);
				}
			}
		}

		public static BloomFilter Read(Stream stream)
		{
			using (var reader = new BinaryReader(stream, Encoding.UTF8, true))
			{
				var hashFunctionCount = reader.ReadInt32();
				var hashBitsCount = reader.ReadInt32();
				var hashBitsData = reader.ReadBytes(hashBitsCount);
				var hashBits = new BitArray(hashBitsCount);
				for (int i = 0; i < hashBitsCount; i++)
					hashBits[i] = hashBitsData[i] != 0;

				return new BloomFilter(hashFunctionCount, hashBits);
			}
		}
	}
}
