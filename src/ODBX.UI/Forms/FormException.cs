// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormException.cs
//   
//  

using System;

namespace ODBX.Forms
{
    public partial class FormException : BaseForm
    {
        public FormException()
        {
            InitializeComponent();
        }

        public void SetException(string title, Exception exception)
        {
            if (exception == null) throw new ArgumentNullException("exception");

            labelTitle.Text = title;
            textBoxDetails.Text = exception.ToString();
        }
    }
}