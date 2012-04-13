// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormApplication.cs
//   
//  

using System;
using System.Windows.Forms;
using ODBX.Common;
using ODBX.Properties;

namespace ODBX.Forms
{
    public partial class FormApplication : BaseForm
    {
        private readonly FormProject _formProject;
        private readonly FormProjectBrowser _formProjectBrowser;
        private readonly FormProgress _formProgress;

        public FormApplication()
        {
            InitializeComponent();
            _formProjectBrowser = new FormProjectBrowser();
            _formProject = new FormProject { MdiParent = this};
            _formProgress = new FormProgress();
        }


        private void ButtonOptionsClick(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var formProjectConfiguration = new FormProjectConfiguration();
                formProjectConfiguration.Project = _formProject.Project;

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

 }
}