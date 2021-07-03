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
    public static string ServerPath = System.IO.Path.Combine(@"C:\Users\Admin\Desktop\New folder\quanlynhasach\server\");
    public static SqlConnection sqlcon;
    public static string name, username, role;
    public static int Slmin, Luongtonmax, Nomax, Tonbanmin, status = 1; // 1 la login, 2 la dashboard, 0 la tat
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
            frmLogin loginForm;
            frmDash_board mainForm;
            while (Globals.status != 0)
            {
                switch (Globals.status)
                {
                    case 1:
                        loginForm = new frmLogin();
                        Application.Run(loginForm);
                        break;
                    case 2:
                        mainForm = new frmDash_board();
                        Application.Run(mainForm);
                        break;
                }
            }
        }
    }
}
