using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Background
        private void button3_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        //Close
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Clear
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }



        //Show the Open File dialog. If the user click Ok, load the picture that the user chose.
        private void showBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK) 
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        //checkBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else 
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
