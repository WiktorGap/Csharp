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

namespace system_with_db
{
    public partial class details : UserControl
    {
        public details()
        {
            InitializeComponent();
            lblPrescription.Hide();
            lblvistDate.Hide();
        }
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\users.mdf;Integrated Security=True";

        private void details_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pesel = txtPeselControlDt.Text;

            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string query = "SELECT LastVisitDate, PrescriptionNote FROM Clients WHERE PESEL = @pesel";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pesel", pesel);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            lblvistDate.Text = reader["LastVisitDate"].ToString();
                            lblPrescription.Text = reader["PrescriptionNote"].ToString();
                            lblvistDate.Show();
                            lblPrescription.Show();
                        }
                        else
                        {
                            lblvistDate.Text = "Brak danych";
                            lblPrescription.Text = "Brak danych";
                        }
                    }
                }
            }
        }


        private void lblPrescription_Click(object sender, EventArgs e)
        {

        }
    }
}
