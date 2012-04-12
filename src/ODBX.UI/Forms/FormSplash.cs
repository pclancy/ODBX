using System;
using System.Windows.Forms;

namespace ODBX.Forms
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplashShown(object sender, EventArgs e)
        {
            var formApplication = new FormApplication();
            formApplication.Show();
            Cursor.Current = Cursors.Default;

        }
    }
}