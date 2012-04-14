using System;
using System.Windows.Forms;
using ODBX.Common;
using ODBX.Properties;

namespace ODBX.Forms
{
    public partial class FormProjectBrowser : BaseForm
    {
        public Project SelectedProject { get; set; }

        public FormProjectBrowser()
        {
            InitializeComponent();
            comboBoxLocation.Items.Add(State.DefaultFilePath);
            comboBoxLocation.SelectedIndex = 0;
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

        private void FormProjectBrowserShown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            buttonAccept.Enabled = false;
            var projectList = State.ScanProjects(comboBoxLocation.Text);
            this.ListViewProjects.SetObjects(projectList);
            Cursor.Current = Cursors.Default;

        }

        private void ButtonAcceptClick(object sender, EventArgs e)
        {
            if (ListViewProjects.SelectedItem == null)
            {
                buttonAccept.Enabled = false;
                return;
            }
            SelectedProject = (Project)ListViewProjects.SelectedItem.RowObject;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ListViewProjectsSelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = (ListViewProjects.SelectedItem != null);
        }
    }
}