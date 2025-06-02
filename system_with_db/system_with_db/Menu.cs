using Microsoft.IdentityModel.Tokens;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\users.mdf;Integrated Security=True";
        private void Menu_Load(object sender, EventArgs e)
        {
            
            this.clientsTableAdapter.Fill(this.usersDataSet.Clients);

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save table data";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                try
                {
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog1.FileName))
                    {
                        for (int i = 0; i < dataGridViewOfPacients.Columns.Count; i++)
                        {
                            writer.Write(dataGridViewOfPacients.Columns[i].HeaderText);
                            if (i < dataGridViewOfPacients.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        foreach (DataGridViewRow row in dataGridViewOfPacients.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dataGridViewOfPacients.Columns.Count; i++)
                                {
                                    var value = row.Cells[i].Value?.ToString().Replace(",", ";");
                                    writer.Write(value);
                                    if (i < dataGridViewOfPacients.Columns.Count - 1)
                                        writer.Write(",");
                                }
                                writer.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Data wrote succesfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string pesel = txtPESEL.Text.Trim();  
            string lastVisitDate = txtLastVisit.Text.Trim();  
            string prescription = txtPrescription.Text.Trim();

           
           

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "INSERT INTO Clients (FirstName, LastName, PESEL, Email, Phone, LastVisitDate, PrescriptionNote) VALUES (@name, @lastName, @pesel, @email, @phone, @lastVisitDate, @prescription)";

                using (SqlCommand cmd = new SqlCommand(query, con)) 
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@pesel", pesel);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@lastVisitDate", lastVisitDate);
                    cmd.Parameters.AddWithValue("@prescription", prescription);

                    int rowsAffected = cmd.ExecuteNonQuery();  

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record added successfully");
                        RefreshGrid();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add record");
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string pesel = txtPESEL.Text.Trim();
            string lastVisitDate = txtLastVisit.Text.Trim();
            string prescription = txtPrescription.Text.Trim();

            string query = "UPDATE Clients SET FirstName=@name, LastName=@lastName, PESEL=@pesel, Email=@email, Phone=@phone, LastVisitDate=@lastVisitDate, PrescriptionNote=@prescription WHERE PESEL=@pesel";

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@pesel", pesel);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@lastVisitDate", lastVisitDate);
                    cmd.Parameters.AddWithValue("@prescription", prescription);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Record updated successfully");
                        RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update record");
                    }
                }
            }
        }




        private void txtResOfValidate_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPESEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void RefreshGrid()
        {
            string query = "SELECT * FROM Clients";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewOfPacients.DataSource = dt;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
           txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPESEL.Text = "";
            txtLastVisit.Text = "";
            txtPrescription.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string pesel = txtPESEL.Text.Trim();


            string query = "DELETE FROM Clients WHERE Pesel=@pesel";

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@pesel", pesel);


                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Record deleted successfully");
                        RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record");
                    }
                }
            }
        }

        private void btnFInd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string pesel = txtPESEL.Text.Trim();
            string lastVisitDate = txtLastVisit.Text.Trim();
            string prescription = txtPrescription.Text.Trim();

            string query = "SELECT * FROM Clients WHERE  FirstName=@name OR LastName=@lastName OR PESEL=@pesel OR Email=@email OR Phone=@phone OR LastVisitDate=@lastVisitDate";

            using(SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue ("@name", name);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@pesel", pesel);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@lastVisitDate", lastVisitDate);
                    cmd.Parameters.AddWithValue("@prescription", prescription);

                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewOfPacients.DataSource = dt;
                    }

                }
            }
            


        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }

        private void toolsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tools toolControl = new tools();
            toolControl.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void ApplyTheme(Color backColor, Color foreColor)
        {
            this.BackColor = backColor;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = backColor;
                ctrl.ForeColor = foreColor;
            }

            menuStrip1.BackColor = backColor;
            menuStrip1.ForeColor = foreColor;
        }

        private void CheckSelectedTheme(ToolStripMenuItem selected)
        {
            defaultToolStripMenuItem.Checked = false;
            darkToolStripMenuItem.Checked = false;
            lightToolStripMenuItem.Checked = false;

            selected.Checked = true;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyTheme(SystemColors.GradientInactiveCaption, Color.Black);
            CheckSelectedTheme(defaultToolStripMenuItem);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyTheme(Color.FromArgb(40, 40, 40), Color.Red);
            CheckSelectedTheme(darkToolStripMenuItem);
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyTheme(Color.White, Color.Black);
            CheckSelectedTheme(lightToolStripMenuItem);
        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
