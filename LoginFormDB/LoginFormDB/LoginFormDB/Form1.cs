using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66K0HM;Initial Catalog=userLogin;Integrated Security=True");

            string q = $"SELECT * FROM Logins WHERE UserName = '{usernameTb.Text.Trim()}' AND Password = '{passTb.Text.Trim()}'";

            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            DataTable dataTable = new DataTable();

            sda.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                Login lForm = new Login();
                this.Hide();
                lForm.Show();
            }
            else
            {
                MessageBox.Show("Username or Password was incorrect. \r\nTrace started...");
            }
        }

        private void logoutB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginB_Click(sender, e);
            }
        }

        private void usernameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginB_Click(sender, e);
            }
        }
    }
}
