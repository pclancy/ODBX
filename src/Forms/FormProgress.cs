// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProgress.cs
//   
//  

using System;
using ODBX.Config;
using ODBX.Driver;

namespace ODBX.Forms
{
    public partial class FormProgress : BaseForm
    {
        public FormProgress()
        {
            InitializeComponent();
        }

        private Project _project;
        public Project Project
        {
            get { return _project; }
            set { _project = value; 
                _project.Driver.FeedbackMessage += DriverOnFeedbackMessage;
            }
        }

        private void DriverOnFeedbackMessage(object sender, FeedbackEventArgs eventArgs)
        {

            labelOperation.Text = eventArgs.Message;
            progressBar1.Value = eventArgs.ProgressPercent;
            labelOperation.Refresh();
        }
    }
}