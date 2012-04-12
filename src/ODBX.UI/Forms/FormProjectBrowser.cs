using System;
using System.Windows.Forms;
using ODBX.Properties;

namespace ODBX.Forms
{
    public partial class FormProjectBrowser : BaseForm
    {
        public FormProjectBrowser()
        {
            InitializeComponent();
        }

        private void ButtonBrowseFolderClick(object sender, System.EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.comboBoxLocation.Items.Insert(0, folderBrowserDialog1.SelectedPath);
                this.comboBoxLocation.SelectedIndex = 0;

            }
        }

        private void ButtonNewProjectClick(object sender, System.EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var formProjectConfiguration = new FormProjectConfiguration();

                if (formProjectConfiguration.ShowDialog(this) == DialogResult.OK)
                {
                    //_formProject.Project = formProjectConfiguration.Project;
                }
            }
            catch (Exception ex)
            {
                Program.HandleException(this, ex, Strings.Error);
            }
            finally
            {

                //ButtonRefresh.Enabled = _formProject.Project != null;
                //_formProject.Bind();
                //_formProject.Show();

                Cursor = Cursors.Default;
            }
        }
    }
}