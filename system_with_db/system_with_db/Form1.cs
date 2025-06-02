using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace system_with_db
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPasswod.Text = "";
            txtPasswod.MaxLength = 14;
            txtPasswod.PasswordChar = '*';

        }

     

        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\users.mdf;Integrated Security=True";


        private void btnLogin_Click(object sender, EventArgs e)
        {

            string password = txtPasswod.Text;
            string login = txtLogin.Text;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Logs WHERE Password_=@password AND Login_=@login";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@login", login);

                        int result = (int)cmd.ExecuteScalar();
                        if (result > 0)
                        {
                            MessageBox.Show("Succesfully Logged ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Menu menu = new Menu();
                            menu.Show();

                        }
                        else
                        {
                            MessageBox.Show("Invalid password or login","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Error "+ ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
