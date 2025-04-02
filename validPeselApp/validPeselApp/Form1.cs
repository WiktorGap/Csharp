using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validPeselApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] processPesel(string pesel)
        {

            int lenghtOfPesel = pesel.Length;

            if (lenghtOfPesel != 11)
            {
                MessageBox.Show("Invalid length of Pesel");
                return null;
            }

            // string pattern = @"^\d{2}([0-1]\d|2[0-9]|3[0-2]|4[0-9]|5[0-2]|6[0-9]|7[0-2])[0-3]\d{4}[0-9]$";

            /*
            if (!Regex.IsMatch(pesel, pattern))
            {
                MessageBox.Show("Invalid PESEL format.");
                return;
            }*/


            int[] intsPesel = new int[lenghtOfPesel];

            for (int i = 0; i < lenghtOfPesel; i++)
            {
                if (char.IsDigit(pesel[i]))
                {
                    intsPesel[i] = pesel[i] - '0';
                }
                else
                {
                    MessageBox.Show("PESEL zawiera niepoprawne znaki.");
                    return null;
                }
            }
            //MessageBox.Show("Tablica wartości PESEL: " + string.Join(", ", intsPesel));
            return intsPesel;

            
        }



    private void btnSubmit_Click(object sender, EventArgs e)
        {
            string pesel = txtValidatePesel.Text;
            int[] peselArr = processPesel(pesel);
            int controlSum = 0;
            int[] valArr = {1,3,7,9,1,3,7,9,1,3 };
            

            if (peselArr == null) 
            {
                MessageBox.Show("Błąd w przetwarzaniu PESEL.");
                return;
            }

            for (int i = 0;i <valArr.Length; i++) 
            {
                controlSum += valArr[i] * peselArr[i];
            }

            int controlNum = 10 - (controlSum % 10);
            if (controlNum == 10) controlNum = 0; 

            if (controlNum == peselArr[10])
            {
                MessageBox.Show("PESEL jest poprawny, liczba kontrolna się zgadza.");
            }
            else
            {
                MessageBox.Show("Niepoprawna cyfra kontrolna w PESEL.");
            }


        }
    }
}
