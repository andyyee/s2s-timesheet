using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OfficeManager.Forms;

namespace OfficeManager
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
            formLogin loginInstance = new formLogin();
            Application.Run(loginInstance);
            if (loginInstance.getLoginValid())
            {
                int userid = loginInstance.getLoginId();
                String username = loginInstance.getLoginName();
                String realname = loginInstance.getRealName();
                MessageBox.Show("Welcome, " + realname + ".");
                Application.Run(new formMain());
            }
        }
    }
}
