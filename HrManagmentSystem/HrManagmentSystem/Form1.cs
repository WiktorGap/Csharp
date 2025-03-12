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
            // Tutaj dodaj implementację zapisu, jeśli potrzebujesz
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
            // Connection string do bazy danych
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            // Tworzenie połączenia z bazą danych
            using (SqlConnection con = new SqlConnection(constring))
            {
                // Zapytanie SQL do pobrania danych z tabeli users
                string query = "SELECT * FROM users";

                // Tworzenie SqlCommand
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;

                    // Tworzenie SqlDataAdapter
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        // Tworzenie DataTable, do którego zostaną załadowane dane
                        DataTable dt = new DataTable();

                        try
                        {
                            // Wypełnienie DataTable danymi z bazy
                            sda.Fill(dt);

                            // Ustawienie DataTable jako źródło danych dla DataGridView
                            dataGridView1.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Błąd podczas ładowania danych: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
