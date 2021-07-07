using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Forms;
using System.Data.SqlClient;


//Class chua bien toan cuc
public static class Globals
{
    public static string ServerPath = Directory.GetCurrentDirectory().ToString();
    public static SqlConnection sqlcon;
    public static string name, username, role;
    public static int Slmin, Luongtonmax, Nomax, Tonbanmin, status = 1; // 1 la login, 2 la dashboard, 0 la tat
    public static bool tienthuvuottienno;
}

namespace QuanLyNhaSach
{
    static class Program
    {
        static void getPath()
        {
            for (int i = 0; i < 5; ++i)
                Globals.ServerPath = Directory.GetParent(Globals.ServerPath).FullName.ToString();
            Globals.ServerPath = Path.Combine(Globals.ServerPath, @"server\");
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            getPath();
            // Create connection to database
            Globals.sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=QLNS;Integrated Security=True");

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
