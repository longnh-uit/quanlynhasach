using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Forms;

namespace QuanLyNhaSach
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin loginForm = new frmLogin();
            Application.Run(loginForm);

            if (loginForm.UserSuccessfullyAuthenticated)
            {
                // MainForm is defined elsewhere
                Application.Run(new frmDash_board());
            }
        }
    }
}
