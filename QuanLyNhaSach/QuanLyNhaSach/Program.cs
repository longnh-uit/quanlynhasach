using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Forms;
using System.Data.SqlClient;

//Class chua bien toan cuc
public static class Globals
{
    public static string ServerPath = System.IO.Path.Combine(@"D:\Courses\NhaSach\server\");
    public static SqlConnection sqlcon;
    public static string name, role;
    public static int Slmin, Luongtonmax, Nomax, Tonbanmin;
    public static bool tienthuvuottienno;
}

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
            // Create connection to database
            Globals.sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;
                          AttachDbFilename=" + Globals.ServerPath + @"QLNS.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;
                          User Instance=True");

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
