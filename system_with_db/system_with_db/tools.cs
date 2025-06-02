using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_with_db
{
    public partial class tools : Form
    {
        public tools()
        {
            InitializeComponent();
            lblIsValidate.Hide();
        }

        private void tools_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pesel = txtValid.Text.Trim();

            if (pesel.Length != 11)
            {
                lblIsValidate.Text = "PESEL musi mieć 11 cyfr.";
                lblIsValidate.Show();
                return;
            }

            int[] peselTab = new int[11];

            for (int i = 0; i < pesel.Length; i++)
            {
                if (!char.IsDigit(pesel[i]))
                {
                    lblIsValidate.Text = "PESEL może zawierać tylko cyfry.";
                    lblIsValidate.Show();
                    return;
                }
                peselTab[i] = pesel[i] - '0';
            }


            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += weights[i] * peselTab[i];
            }

            int controlDigit = (10 - (sum % 10)) % 10;

            if (controlDigit == peselTab[10])
            {
                lblIsValidate.Text = "PESEL jest poprawny";
                lblIsValidate.Show();
            }
            else
            {
                lblIsValidate.Text = "PESEL jest niepoprawny";
                lblIsValidate.Show();
            }
        }

        private void lblIsValidate_Click(object sender, EventArgs e)
        {

        }
    }
}
