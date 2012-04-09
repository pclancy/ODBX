using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ODBX.Forms;

namespace ODBX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormProjectConfiguration());
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
