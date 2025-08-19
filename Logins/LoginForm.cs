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

namespace FeeTypeForm.Logins
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            using (SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        Session.CurrentUser = username; // Store logged-in user
                        this.Hide();
                        FrmFee main = new FrmFee();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
