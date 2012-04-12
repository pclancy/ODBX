using System;
using System.Windows.Forms;
using ODBX.Config;
using ODBX.Properties;

namespace ODBX.Forms
{
    public partial class FormProjectBrowser : BaseForm
    {
        public Project SelectedProject { get; set; }

        public FormProjectBrowser()
        {
            InitializeComponent();
        }

        private void ButtonBrowseFolderClick(object sender, System.EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                comboBoxLocation.Items.Insert(0, folderBrowserDialog1.SelectedPath);
                comboBoxLocation.SelectedIndex = 0;

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
                    SelectedProject = formProjectConfiguration.Project;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                Program.HandleException(this, ex, Strings.Error);
            }
            finally
            {

                Cursor = Cursors.Default;
            }
        }
    }
}