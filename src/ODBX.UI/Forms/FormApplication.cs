// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormApplication.cs
//   
//  

using System;
using System.Linq;
using System.Windows.Forms;
using ODBX.Common;
using ODBX.Properties;

namespace ODBX.Forms
{
    public partial class FormApplication : BaseForm
    {
        private FormProgress _formProgress;
        private FormProject _formProject;
        private FormProjectBrowser _formProjectBrowser;

        public FormApplication()
        {
            InitializeComponent();
        }


        private void ButtonOptionsClick(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var formProjectConfiguration = new FormProjectConfiguration {Project = _formProject.Project};

                if (formProjectConfiguration.ShowDialog(this) == DialogResult.OK)
                {
                    Bind(formProjectConfiguration.Project);
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

        private void ButtonRefreshClick(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Bind(_formProject.Project);
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


        private void Bind(Project project)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                ButtonRefresh.Enabled = ButtonOptions.Enabled = ButtonSynchronise.Enabled = false;

                if (project != null)
                {
                    _formProgress.Project = project;
                    if (_formProgress.ShowDialog(this) == DialogResult.OK)
                    {
                        Focus();
                        _formProject.Bind(project);
                        ButtonRefresh.Enabled = ButtonOptions.Enabled = ButtonSynchronise.Enabled = true;
                        _formProject.Show();
                    }
                }
                else
                {
                    _formProject.Hide();
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

        private void OpenProjectBrowser(object sender, EventArgs e)
        {
            if (_formProjectBrowser.ShowDialog() == DialogResult.OK)
            {
                Bind(_formProjectBrowser.SelectedProject);
            }
        }

        private void FormApplicationShown(object sender, EventArgs e)
        {
            Refresh();
            _formProjectBrowser = new FormProjectBrowser();
            _formProject = new FormProject {MdiParent = this, WindowState = FormWindowState.Maximized};
            _formProgress = new FormProgress();

            ComboBoxGroupBy.SelectedIndex = 2;
            OpenProjectBrowser(sender, e);
        }

        private void ButtonSynchroniseClick(object sender, EventArgs e)
        {
            var formSynchronise = new FormSynchronise();

            formSynchronise.Bind(_formProject.Project, _formProject.GetSelectedObjects());
            formSynchronise.ShowDialog(this);
        }

        private void ComboBoxGroupBySelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _formProject.GroupBy = ((GroupByView) ComboBoxGroupBy.SelectedIndex);
            _formProject.BuildView();
            Cursor.Current = Cursors.Default;
        }
    }
}