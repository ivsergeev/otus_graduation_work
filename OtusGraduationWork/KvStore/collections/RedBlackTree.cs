using System;
using System.Collections.Generic;

namespace OtusGraduationWork.KvStore.collections
{
    public class RedBlackTree<TKey, TValue>
          where TValue : class
          where TKey : IComparable<TKey>, IComparable, IEquatable<TKey>
    {
        private enum RedBlackNodeType
        {
            Red = 0,
            Black = 1
        }

        private class RedBlackNode
        {
            public RedBlackNodeType Color
            {
                get;
                set;
            }
            public RedBlackNode Left
            {
                get;
                set;
            }
            public RedBlackNode Right
            {
                get;
                set;
            }
            public RedBlackNode Parent
            {
                get;
                set;
            }
            public TKey Key
            {
                get;
                set;
            }
            public TValue Value
            {
                get;
                set;
            }
            public bool IsEmpty
            {
                get
                {
                    return Left == null &&
                           Right == null &&
                           Parent == null &&
                           Color == RedBlackNodeType.Black;
                }
            }

            public RedBlackNode()
            {
            }
            public RedBlackNode(TKey key, TValue data)
                : this()
            {
                Key = key;
                Value = data;
                Color = RedBlackNodeType.Red;
                Right = Empty();
                Left = Empty();
            }

            public static RedBlackNode Empty()
            {
                return new RedBlackNode()
                {
                    Left = null,
                    Right = null,
                    Parent = null,
                    Color = RedBlackNodeType.Black
                };
            }
        }

        private RedBlackNode _root;
        private int _count;

        public int Count
        {
            get { return _count; }
        }

        public RedBlackTree()
        {
            this._root = RedBlackNode.Empty();
            this._count = 0;
        }

        public void Clear()
        {
            _root = RedBlackNode.Empty();

        }

        public TValue Get(TKey key)
        {
            return FindNode(key)?.Value;
        }

        public TValue Set(TKey key, TValue value)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            var parent = default(RedBlackNode);
            var workNode = _root;

            while (!workNode.IsEmpty)
            {
                parent = workNode;

                int result = key.CompareTo(workNode.Key);
                if (result == 0)
                {
                    var oldValue = workNode.Value;
                    workNode.Value = value;
                    return oldValue;
                }

                workNode = result > 0 ? workNode.Right : workNode.Left;
            }

            var newNode = new RedBlackNode(key, value);
            if (parent != null)
            {
                newNode.Parent = parent;

                if (newNode.Key.CompareTo(newNode.Parent.Key) > 0)
                {
                    newNode.Parent.Right = newNode;
                }
                else
                {
                    newNode.Parent.Left = newNode;
                }
            }
            else
            {
                _root = newNode;
            }

            _count++;

            BalanceTreeAfterInsert(newNode);

            return null;
        }

        public bool Remove(TKey key)
        {
            var deleteNode = FindNode(key);
            if (deleteNode == null)
                return false;

            var workNode = default(RedBlackNode);

            if (deleteNode.Left.IsEmpty || deleteNode.Right.IsEmpty)
            {
                workNode = deleteNode;
            }
            else
            {
                workNode = deleteNode.Right;

                while (!workNode.Left.IsEmpty)
                {
                    workNode = workNode.Left;
                }
            }

            var linkedNode = !workNode.Left.IsEmpty ? workNode.Left : workNode.Right;
            linkedNode.Parent = workNode.Parent;

            if (workNode.Parent != null)
            {
                if (workNode == workNode.Parent.Left)
                {
                    workNode.Parent.Left = linkedNode;
                }
                else
                {
                    workNode.Parent.Right = linkedNode;
                }
            }
            else
            {
                _root = linkedNode;
            }

            if (workNode != deleteNode)
            {
                deleteNode.Key = workNode.Key;
                deleteNode.Value = workNode.Value;
            }

            if (workNode.Color == RedBlackNodeType.Black)
            {
                BalanceTreeAfterDelete(linkedNode);
            }

            _count--;

            return true;
        }

        private enum EnumDirection
        {
            FromParent = 0,
            FromLeft = 1,
            FromRight = 2,
        }

        public IEnumerable<KeyValuePair<TKey, TValue>> Items()
        {
            var node = _root;
            if (node.IsEmpty)
                yield break;

            var stack = new Stack<Tuple<RedBlackNode, EnumDirection>>();
            stack.Push(new Tuple<RedBlackNode, EnumDirection>(node, EnumDirection.FromParent));

            while (stack.Count > 0)
            {
                var item = stack.Pop();

                node = item.Item1;

                switch (item.Item2)
                {
                    case EnumDirection.FromParent:

                        if (node.Left.IsEmpty)
                        {
                            yield return new KeyValuePair<TKey, TValue>(node.Key, node.Value);

                            if (!node.Right.IsEmpty)
                            {
                                stack.Push(new Tuple<RedBlackNode, EnumDirection>(
                                    node.Right,
                                    EnumDirection.FromParent));
                            }
                            else
                            {
                                if (node.Parent != null && !node.Parent.IsEmpty)
                                {
                                    stack.Push(new Tuple<RedBlackNode, EnumDirection>(
                                        node.Parent,
                                        node.Parent.Left == node ? EnumDirection.FromLeft : EnumDirection.FromRight));
                                }
                            }
                        }
                        else
                        {
                            stack.Push(new Tuple<RedBlackNode, EnumDirection>(
                                node.Left,
                                EnumDirection.FromParent));
                        }

                        break;

                    case EnumDirection.FromLeft:

                        yield return new KeyValuePair<TKey, TValue>(node.Key, node.Value);

                        if (!node.Right.IsEmpty)
                        {
                            stack.Push(new Tuple<RedBlackNode, EnumDirection>(
                                node.Right,
                                EnumDirection.FromParent));
                        }
                        else
                        {
                            if (node.Parent != null && !node.Parent.IsEmpty)
                            {
                                stack.Push(new Tuple<RedBlackNode, EnumDirection>(
                                    node.Parent,
                                    node.Parent.Left == node ? EnumDirection.FromLeft : EnumDirection.FromRight));
                            }
                        }

                        break;
                    case EnumDirection.FromRight:

                        if (node.Parent != null && !node.Parent.IsEmpty)
                        {
                            stack.Push(new Tuple<RedBlackNode, EnumDirection>(
                                node.Parent,
                                node.Parent.Left == node ? EnumDirection.FromLeft : EnumDirection.FromRight));
                        }

                        break;
                }
            }
        }

        private RedBlackNode FindNode(TKey key)
        {
            var treeNode = _root;

            while (!treeNode.IsEmpty)
            {
                var result = key.CompareTo(treeNode.Key);
                if (result == 0)
                {
                    return treeNode;
                }

                treeNode = result < 0
                    ? treeNode.Left
                    : treeNode.Right;
            }
            return null;
        }

        private void RotateRight(RedBlackNode rotateNode)
        {
            var workNode = rotateNode.Left;

            rotateNode.Left = workNode.Right;

            if (!workNode.Right.IsEmpty)
            {
                workNode.Right.Parent = rotateNode;
            }

            if (!workNode.IsEmpty)
            {
                workNode.Parent = rotateNode.Parent;
            }

            if (rotateNode.Parent != null)
            {
                if (rotateNode == rotateNode.Parent.Right)
                {
                    rotateNode.Parent.Right = workNode;
                }
                else
                {
                    rotateNode.Parent.Left = workNode;
                }
            }
            else
            {
                _root = workNode;
            }

            workNode.Right = rotateNode;
            if (!rotateNode.IsEmpty)
            {
                rotateNode.Parent = workNode;
            }
        }

        private void RotateLeft(RedBlackNode rotateNode)
        {
            var workNode = rotateNode.Right;

            rotateNode.Right = workNode.Left;

            if (!workNode.Left.IsEmpty)
            {
                workNode.Left.Parent = rotateNode;
            }

            if (!workNode.IsEmpty)
            {
                workNode.Parent = rotateNode.Parent;
            }

            if (rotateNode.Parent != null)
            {
                if (rotateNode == rotateNode.Parent.Left)
                {
                    rotateNode.Parent.Left = workNode;
                }
                else
                {
                    rotateNode.Parent.Right = workNode;
                }
            }
            else
            {
                _root = workNode;
            }

            workNode.Left = rotateNode;
            if (!rotateNode.IsEmpty)
            {
                rotateNode.Parent = workNode;
            }
        }

        private void BalanceTreeAfterDelete(RedBlackNode linkedNode)
        {
            while (linkedNode != _root && linkedNode.Color == RedBlackNodeType.Black)
            {
                var workNode = default(RedBlackNode);

                if (linkedNode == linkedNode.Parent.Left)
                {
                    workNode = linkedNode.Parent.Right;

                    if (workNode.Color == RedBlackNodeType.Red)
                    {
                        linkedNode.Parent.Color = RedBlackNodeType.Red;
                        workNode.Color = RedBlackNodeType.Black;

                        RotateLeft(linkedNode.Parent);

                        workNode = linkedNode.Parent.Right;
                    }

                    if (workNode.Left.Color == RedBlackNodeType.Black &&
                        workNode.Right.Color == RedBlackNodeType.Black)
                    {
                        workNode.Color = RedBlackNodeType.Red;
                        linkedNode = linkedNode.Parent;
                    }
                    else
                    {
                        if (workNode.Right.Color == RedBlackNodeType.Black)
                        {
                            workNode.Left.Color = RedBlackNodeType.Black;
                            workNode.Color = RedBlackNodeType.Red;
                            RotateRight(workNode);
                            workNode = linkedNode.Parent.Right;
                        }

                        linkedNode.Parent.Color = RedBlackNodeType.Black;
                        workNode.Color = linkedNode.Parent.Color;
                        workNode.Right.Color = RedBlackNodeType.Black;

                        RotateLeft(linkedNode.Parent);

                        linkedNode = _root;
                    }
                }
                else
                {
                    workNode = linkedNode.Parent.Left;
                    if (workNode.Color == RedBlackNodeType.Red)
                    {
                        linkedNode.Parent.Color = RedBlackNodeType.Red;
                        workNode.Color = RedBlackNodeType.Black;
                        RotateRight(linkedNode.Parent);
                        workNode = linkedNode.Parent.Left;
                    }
                    if (workNode.Right.Color == RedBlackNodeType.Black &&
                        workNode.Left.Color == RedBlackNodeType.Black)
                    {
                        workNode.Color = RedBlackNodeType.Red;
                        linkedNode = linkedNode.Parent;
                    }
                    else
                    {
                        if (workNode.Left.Color == RedBlackNodeType.Black)
                        {
                            workNode.Right.Color = RedBlackNodeType.Black;
                            workNode.Color = RedBlackNodeType.Red;
                            RotateLeft(workNode);
                            workNode = linkedNode.Parent.Left;
                        }
                        workNode.Color = linkedNode.Parent.Color;
                        linkedNode.Parent.Color = RedBlackNodeType.Black;
                        workNode.Left.Color = RedBlackNodeType.Black;
                        RotateRight(linkedNode.Parent);
                        linkedNode = _root;
                    }
                }
            }
            linkedNode.Color = RedBlackNodeType.Black;
        }

        private void BalanceTreeAfterInsert(RedBlackNode insertedNode)
        {
            while (insertedNode != _root && insertedNode.Parent.Color == RedBlackNodeType.Red)
            {
                var workNode = default(RedBlackNode);
                if (insertedNode.Parent == insertedNode.Parent.Parent.Left)
                {
                    workNode = insertedNode.Parent.Parent.Right;
                    if (workNode != null && workNode.Color == RedBlackNodeType.Red)
                    {
                        insertedNode.Parent.Color = RedBlackNodeType.Black;
                        workNode.Color = RedBlackNodeType.Black;
                        insertedNode.Parent.Parent.Color = RedBlackNodeType.Red;
                        insertedNode = insertedNode.Parent.Parent;
                    }
                    else
                    {
                        if (insertedNode == insertedNode.Parent.Right)
                        {
                            insertedNode = insertedNode.Parent;
                            RotateLeft(insertedNode);
                        }
                        insertedNode.Parent.Color = RedBlackNodeType.Black;
                        insertedNode.Parent.Parent.Color = RedBlackNodeType.Red;
                        RotateRight(insertedNode.Parent.Parent);
                    }
                }
                else
                {
                    workNode = insertedNode.Parent.Parent.Left;
                    if (workNode != null && workNode.Color == RedBlackNodeType.Red)
                    {
                        insertedNode.Parent.Color = RedBlackNodeType.Black;
                        workNode.Color = RedBlackNodeType.Black;
                        insertedNode.Parent.Parent.Color = RedBlackNodeType.Red;
                        insertedNode = insertedNode.Parent.Parent;
                    }
                    else
                    {
                        if (insertedNode == insertedNode.Parent.Left)
                        {
                            insertedNode = insertedNode.Parent;
                            RotateRight(insertedNode);
                        }
                        insertedNode.Parent.Color = RedBlackNodeType.Black;
                        insertedNode.Parent.Parent.Color = RedBlackNodeType.Red;
                        RotateLeft(insertedNode.Parent.Parent);
                    }
                }
            }

            _root.Color = RedBlackNodeType.Black;
        }
    }
}
