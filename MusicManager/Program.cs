using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Open the login form
            LoginForm loginForm = new LoginForm();
            //Application.Run(loginForm);

            //Check if user did login, then destroy the login form
            DialogResult result = loginForm.DialogResult;
            loginForm.Dispose();

            //Open main form only if user is logged in
            //if(result == DialogResult.OK)
            {
                Application.Run(new searchAndStats());
            }

        }
    }
}
