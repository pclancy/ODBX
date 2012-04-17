// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProjectBrowser.cs
//   
//  

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ODBX.Common;
using ODBX.Properties;

namespace ODBX.Forms
{
    public partial class FormProjectBrowser : BaseForm
    {
        public FormProjectBrowser()
        {
            InitializeComponent();
            comboBoxLocation.Items.Add(State.SavedProjectsFolder);
            comboBoxLocation.SelectedIndex = 0;
        }

        public Project SelectedProject { get; set; }

        private void ButtonBrowseFolderClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                comboBoxLocation.Items.Insert(0, folderBrowserDialog1.SelectedPath);
                comboBoxLocation.SelectedIndex = 0;
            }
        }

        private void ButtonNewProjectClick(object sender, EventArgs e)
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
            ScanProjects();
        }

        private void ButtonAcceptClick(object sender, EventArgs e)
        {
            if (ListViewProjects.SelectedItem == null)
            {
                buttonAccept.Enabled = false;
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ListViewProjectsSelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = buttonEditProject.Enabled = (ListViewProjects.SelectedItem != null);
            if (ListViewProjects.SelectedItem == null)
                SelectedProject = null;
            else
                SelectedProject = (Project) ListViewProjects.SelectedItem.RowObject;
        }

        private void ButtonEditProjectClick(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var formProjectConfiguration = new FormProjectConfiguration {Project = SelectedProject};

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

        private void ScanProjects()
        {
            Cursor.Current = Cursors.WaitCursor;
            buttonAccept.Enabled = false;
            List<Project> projectList = State.ScanProjects(comboBoxLocation.Text);
            ListViewProjects.SetObjects(projectList);
            Cursor.Current = Cursors.Default;
        }

        private void ScanProjects(object sender, EventArgs e)
        {
            ScanProjects();
        }
    }
}