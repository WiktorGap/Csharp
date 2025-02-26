using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StandardUsrDesktopApp
{
    public partial class mainFrame : Form
    {
        public mainFrame()
        {
            InitializeComponent();
        }

        private void mainFrame_Load(object sender, EventArgs e)
        {

        }

        // Funkcja do wczytania pliku
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            string fileName = txtFileNameBox.Text.Trim();

            if (!File.Exists(fileName))
            {
                MessageBox.Show("Plik nie istnieje! Sprawdź poprawność nazwy i ścieżki.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string fileContent = File.ReadAllText(fileName);
                txtFileContent.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas odczytu pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funkcja do zliczania wystąpień litery
        private void btnCountLetter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileContent.Text))
            {
                MessageBox.Show("Najpierw wczytaj plik!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtLetter.Text.Length != 1)
            {
                MessageBox.Show("Podaj jedną literę!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char letter = txtLetter.Text[0];
            int count = txtFileContent.Text.Count(c => c == letter);
            lblLetterCount.Text = $"Litera '{letter}' występuje {count} razy.";
        }

        // Funkcja do wyszukiwania słowa
        private void btnFindWord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileContent.Text))
            {
                MessageBox.Show("Najpierw wczytaj plik!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string word = txtWord.Text.Trim();
            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Podaj słowo do wyszukania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int occurrences = txtFileContent.Text.Split(new[] { ' ', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                                 .Count(w => w.Equals(word, StringComparison.OrdinalIgnoreCase));

            lblWordCount.Text = $"Słowo '{word}' występuje {occurrences} razy.";
        }
    }
}
