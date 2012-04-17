// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProgress.cs
//   
//  

using System;
using System.Windows.Forms;
using ODBX.Common;
using ODBX.Driver;

namespace ODBX.Forms
{
    public partial class FormProgress : BaseForm
    {
        private Project _project;

        public FormProgress()
        {
            InitializeComponent();
        }

        public Project Project
        {
            get { return _project; }
            set
            {
                _project = value;
                _project.Driver.FeedbackMessage += DriverOnFeedbackMessage;
            }
        }

        private void DriverOnFeedbackMessage(object sender, FeedbackEventArgs eventArgs)
        {
            labelOperation.Text = eventArgs.Message;
            progressBar1.Value = eventArgs.ProgressPercent;
            labelOperation.Refresh();
        }

        private void FormProgressShown(object sender, EventArgs e)
        {
            buttonAccept.Enabled = false;
            buttonCancel.Enabled = true;
            Refresh();
            Project.Refresh();
            buttonAccept.Enabled = true;
            buttonCancel.Enabled = false;
            if (checkBoxAutoClose.Checked)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            buttonCancel.Enabled = false;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}