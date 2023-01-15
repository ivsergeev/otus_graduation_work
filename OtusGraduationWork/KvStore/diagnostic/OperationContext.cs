using System;
using System.Diagnostics;

namespace OtusGraduationWork.KvStore.diagnostic
{
    public sealed class OperationContext : IDisposable
    {
        private static OperationContext _current = new OperationContext();

        public static OperationContext Current
        {
            get { return _current; }
        }

        public static OperationContext Create()
        {
            return new OperationContext();
        }

        public void Dispose()
        {
            _current = new OperationContext();
        }

        public int IndexSearchCount
        {
            get;
            set;
        }

        public int IndexHitCount
        {
            get;
            set;
        }

        public int ImmutableIndexSearchCount
        {
            get;
            set;
        }

        public int ImmutableIndexHitCount
        {
            get;
            set;
        }

        public int SsTableSearchCount
        {
            get;
            set;
        }

        public int SsTableHitCount
        {
            get;
            set;
        }

        public int SsTableFilterSearchCount
        {
            get;
            set;
        }

        public int SsTableFilterHitCount
        {
            get;
            set;
        }

        public int SsTableIndexSearchCount
        {
            get;
            set;
        }

        public int SsTableIndexHitCount
        {
            get;
            set;
        }

        public int SsTableBlockHitCount
        {
            get;
            set;
        }

        private OperationContext()
        {
        }
    }
}
