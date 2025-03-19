using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HrManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFind.Width = btnFind.Width * 2;
            btnEdit.Width = btnEdit.Width * 2;
            btnDelete.Width = btnEdit.Width * 2;
        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFind.Width = btnFind.Width / 2;
            btnEdit.Width = btnEdit.Width / 2;
            btnDelete.Width = btnEdit.Width / 2;
        }

        private void backgorundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Wczytaj dane po załadowaniu formy
            LoadData();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implementacja po kliknięciu w Source (jeśli wymaga)
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDataFromFileDialog.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxName.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obsługuje kliknięcia w komórki DataGridView (jeśli chcesz dodać jakąś funkcjonalność)
        }

        private void LoadData()
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT * FROM users";

                using (SqlDataAdapter sda = new SqlDataAdapter(query, con)) // Bezpośrednie przekazanie zapytania SQL
                {
                    DataTable dt = new DataTable();

                    try
                    {
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas ładowania danych: " + ex.Message);
                    }
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string name = txtboxName.Text.Trim();
            string surname = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();
            string id = idTextBox.Text.Trim();

            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT * FROM users WHERE 1=1";
                // Where 1=1 jest zawsze prawdą, więc możemy dodawać warunki bez obawy o składnię

                if (!string.IsNullOrEmpty(name))
                    query += " AND name LIKE @name";
                if (!string.IsNullOrEmpty(surname))
                    query += " AND surname LIKE @surname";
                if (!string.IsNullOrEmpty(phone))
                    query += " AND phone LIKE @phone";
                if (!string.IsNullOrEmpty(id)) // Dodanie warunku dla id
                    query += " AND id LIKE @id"; // Zakładam, że id jest przechowywane jako tekst

                using (var cmd = new SqlCommand(query, con))
                {
                    if (!string.IsNullOrEmpty(name))
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    if (!string.IsNullOrEmpty(surname))
                        cmd.Parameters.AddWithValue("@surname", "%" + surname + "%");
                    if (!string.IsNullOrEmpty(phone))
                        cmd.Parameters.AddWithValue("@phone", "%" + phone + "%");
                    if (!string.IsNullOrEmpty(id)) // Dodanie parametru dla id
                        cmd.Parameters.AddWithValue("@id", "%" + id + "%");

                    using (var sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        try
                        {
                            con.Open();
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Finding error: " + ex.Message);
                        }
                    }
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = txtboxName.Text.Trim();
            string surname = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();
            string id = idTextBox.Text.Trim();

            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            using (var con = new SqlConnection(constring))
            {
                string query = "UPDATE users SET name=@name,surname=@surname,phone=@phone WHERE id=@id ";
                if (!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(surname) || !string.IsNullOrEmpty(phone) || !string.IsNullOrEmpty(id))
                {
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            try
                            {
                                con.Open();
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                LoadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Editing Error" + ex.Message);

                            }
                        }
                    }
                }

            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID.");
                return;
            }

            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            using (var con = new SqlConnection(constring))
            {
                string deleteQuery = "DELETE FROM users WHERE id=@id";

                using (var cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                            LoadData();

                        }
                        else
                        {
                            MessageBox.Show("No record found with the given ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Deleting error: " + ex.Message);
                    }
                }
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            string name = txtboxName.Text.Trim();
            string surname = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();

            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            if (!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(surname) || !string.IsNullOrEmpty(phone))
            {
                using (var con = new SqlConnection(constring))
                {
                    string query = "INSERT INTO users(name,surname,phone) VALUES (@name,@surname,@phone) ";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        try
                        {
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Eror adding");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Adding " + ex.Message);
                        }

                    }
                }
            }
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}