// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Program.cs
//   
//  

using System;
using System.Windows.Forms;
using ODBX.Forms;

namespace ODBX
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormApplication());
        }

        public static void HandleException(Form owner, Exception exception, string title)
        {
            var form = new FormException();
            form.SetException(title, exception);
            form.ShowDialog(owner);
            // todo: log
        }
    }
}