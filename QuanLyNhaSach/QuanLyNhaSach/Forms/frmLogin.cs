using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyNhaSach.Forms;

namespace QuanLyNhaSach
{
    public partial class frmLogin : Form
    {
        public bool UserSuccessfullyAuthenticated { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Globals.sqlcon.Open();
            // Make query
            string query = "Select * from ADMINISTRATORS where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text +"'";
            // Create adapter
            SqlDataAdapter sda = new SqlDataAdapter(query, Globals.sqlcon);
            DataTable dtb1 = new DataTable();
            // Fill the table with whichever entry in the DB fits the criteria of: having the username put in the txtUsername.Text
            // and password from txtPassword.Text
            sda.Fill(dtb1);
            Globals.sqlcon.Close();
            // If there is 1 element (a match has been found), allow access
            if (dtb1.Rows.Count == 1)
            {
                UserSuccessfullyAuthenticated = true;
                Globals.name = dtb1.Rows[0].Field <string>(0);
                Globals.role = dtb1.Rows[0].Field <string>(3);

                Close();

            }
            // If incorrect, don't allow access
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập không tồn tại");
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
