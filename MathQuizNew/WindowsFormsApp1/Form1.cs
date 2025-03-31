using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        char[] sign = { '+', '-', '*', ':' };
        int correctAnswers = 0;
        int incorrectAnswers = 0;
        int result = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            int randomFirst = rnd.Next(1, 50);
            int randomSecond = rnd.Next(1, 50);
            int idxOfSign = rnd.Next(sign.Length);

            lblFirstRandomNum.Text = randomFirst.ToString();
            lblSecRandomNum.Text = randomSecond.ToString();

            switch (sign[idxOfSign])
            {
                case '+':
                    lblSignRandom.Text = "+";
                    result = randomFirst + randomSecond;
                    break;
                case '-':
                    lblSignRandom.Text = "-";
                    result = randomFirst - randomSecond;
                    break;
                case '*':
                    lblSignRandom.Text = "*";
                    result = randomFirst * randomSecond;
                    break;
                case ':':
                    lblSignRandom.Text = ":";
                    result = randomFirst / randomSecond;
                    break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInpurResult.Text, out int userAnswer))
            {
                if (userAnswer == result)
                {
                    correctAnswers++;
                    lblCorrectCounter.Text = $"Correct Answers: {correctAnswers}";
                    lblCorrectCounter.ForeColor = Color.Green;  // Ustawienie koloru zielonego dla poprawnych odpowiedzi
                    lblIncorrectAnswer.ForeColor = Color.Black;  // Resetowanie koloru dla błędnych odpowiedzi
                }
                else
                {
                    incorrectAnswers++;
                    lblIncorrectAnswer.Text = $"Incorrect Answers: {incorrectAnswers}";
                    lblIncorrectAnswer.ForeColor = Color.Red;  // Ustawienie koloru czerwonego dla błędnych odpowiedzi
                    lblCorrectCounter.ForeColor = Color.Black;  // Resetowanie koloru dla poprawnych odpowiedzi
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }

            txtInpurResult.Clear();  // Clear the input field for the next question
            btnStart.PerformClick();  // Start a new question
        }

        private void lblIncorrect_Click(object sender, EventArgs e)
        {

        }
    }
}
