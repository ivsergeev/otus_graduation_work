using OtusGraduationWork.KvStore.diagnostic;
using System.Windows.Forms;

namespace OtusGraduationWork.UI
{
    public partial class OperationResult : Form
    {
        public OperationResult()
        {
            InitializeComponent();
        }

        public OperationResult(long elapsed) : this()
        {
            lbElapsed.Text = elapsed.ToString();
            lbIndexSearchCount.Text = OperationContext.Current.IndexSearchCount.ToString();
            lbIndexHitCount.Text = OperationContext.Current.IndexHitCount.ToString();
            lbTableSearchCount.Text = OperationContext.Current.SsTableSearchCount.ToString();
            lbTableHitCount.Text = OperationContext.Current.SsTableHitCount.ToString();
            lbSsTableFilterSearchCount.Text = OperationContext.Current.SsTableFilterSearchCount.ToString();
            lbSsTableFilterHitCount.Text = OperationContext.Current.SsTableFilterHitCount.ToString();
            lbSsTableIndexSearchCount.Text = OperationContext.Current.SsTableIndexSearchCount.ToString();
            lbSsTableIndexHitCount.Text = OperationContext.Current.SsTableIndexHitCount.ToString();
            lbSsTableBlockHitCount.Text = OperationContext.Current.SsTableBlockHitCount.ToString();
        }
    }
}
