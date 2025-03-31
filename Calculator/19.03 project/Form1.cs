using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._03_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<double> nums = new List<double>(); // Zmieniamy typ na double
        string currentInput = "";
        string operation = "";

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                nums.Add(double.Parse(currentInput));  // Zamiana na double
                currentInput = "";
            }
            operation = "+";
            lblResukt.Text += " +";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            currentInput += "1";
            lblResukt.Text = currentInput;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            currentInput += "2";
            lblResukt.Text = currentInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            currentInput += "3";
            lblResukt.Text = currentInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            currentInput += "4";
            lblResukt.Text = currentInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            currentInput += "5";
            lblResukt.Text = currentInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            currentInput += "7";
            lblResukt.Text = currentInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            currentInput += "8";
            lblResukt.Text = currentInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            currentInput += "9";
            lblResukt.Text = currentInput;
        }

        // Obsługa przycisku 0
        private void btn0_Click_1(object sender, EventArgs e)
        {
            currentInput += "0";
            lblResukt.Text = currentInput;
        }

        // Obsługa przycisku 6
        private void btn6_Click(object sender, EventArgs e)
        {
            currentInput += "6";
            lblResukt.Text = currentInput;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                nums.Add(double.Parse(currentInput));  // Zamiana na double
            }

            double result = nums[0];  // Rozpoczynamy wynik od pierwszej liczby w liście

            for (int i = 1; i < nums.Count; i++)
            {
                if (operation == "+")
                {
                    result += nums[i];
                }
                else if (operation == "-")
                {
                    result -= nums[i];
                }
                else if (operation == "*")
                {
                    result *= nums[i];
                }
                else if (operation == "/")
                {
                    if (nums[i] != 0)
                    {
                        result /= nums[i];
                    }
                    else
                    {
                        lblResukt.Text = "Error: Division by zero";
                        return;
                    }
                }
            }

            lblResukt.Text = result.ToString();

            // Resetowanie stanu po wykonaniu operacji
            nums.Clear();
            nums.Add(result); // Dodaj wynik do listy do dalszych operacji
            currentInput = "";
            operation = "";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                nums.Add(double.Parse(currentInput));  // Zamiana na double
                currentInput = "";
            }
            operation = "*";
            lblResukt.Text += " *";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                nums.Add(double.Parse(currentInput));  // Zamiana na double
                currentInput = "";
            }
            operation = "-";
            lblResukt.Text += " -";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                nums.Add(double.Parse(currentInput));  // Zamiana na double
                currentInput = "";
            }
            operation = "/";
            lblResukt.Text += " /";
        }

        // Nowa metoda obsługująca przycisk Clear
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            nums.Clear();
            currentInput = "";
            operation = "";
            lblResukt.Text = "";
        }
    }
}
