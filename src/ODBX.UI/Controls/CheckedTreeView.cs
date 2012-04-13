using System.Windows.Forms;

namespace ODBX.Controls
{
    public class CheckedTreeView : TreeView
    {
        protected override void WndProc(ref Message m)
        {
            // Filter WM_LBUTTONDBLCLK
            if (m.Msg != 0x203) base.WndProc(ref m);
        }
    }
}