// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProgress.cs
//   
//  

using ODBX.Config;
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

        private void FormProgressShown(object sender, System.EventArgs e)
        {
            Refresh();
            Project.Refresh();
            buttonAccept.Enabled = true;
        }


    }
}