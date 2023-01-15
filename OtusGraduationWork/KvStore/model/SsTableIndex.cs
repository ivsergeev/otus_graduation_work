using System;
using System.Collections.Generic;
using System.Linq;

namespace OtusGraduationWork.KvStore.model
{
    [Serializable]
    public sealed class SsTableIndex
    {
        private SsTableIndexItem[] _items;
        public SsTableIndex(IEnumerable<SsTableIndexItem> items)
        {
            this._items = items.ToArray();
        }
        public SsTableIndexItem SearchNearest(string key)
        {
            int idx = -1;
            int min = 0;
            int max = _items.Length - 1;

            while (min <= max)
            {
                var mid = (min + max) / 2;
                var result = key.CompareTo(_items[mid].Key);

                if (result == 0)
                {
                    idx = mid;
                    break;
                }
                else if (result < 0)
                {
                    max = mid - 1;
                }
                else
                {
                    idx = mid;
                    min = mid + 1;
                }
            }

            return idx == -1 ? null : _items[idx];
        }
    }
}