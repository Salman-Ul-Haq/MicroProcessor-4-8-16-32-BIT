using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroProcessor_Designer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fetchbtn.Enabled = false;
            fetchbtn.BackColor = Color.Gray;

            decodebtn.Enabled = false;
            decodebtn.BackColor = Color.Gray;

            execbtn.Enabled = false;
            execbtn.BackColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void INSTRUCTIONS_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p0.Text = "0001 1000";
            p1.Text = "0011 1001";
            p2.Text = "0010 1010";
            p3.Text = "1000 1010";
            p4.Text = "0000 0000";
            p5.Text = "0000 0000";
            p6.Text = "0000 0000";
            p7.Text = "0000 0000";

            da0.Text = "0001";
            da1.Text = "0010";
            da2.Text = "0010";
            da3.Text = "0010";
            da4.Text = "0010";
            da5.Text = "0010";
            da6.Text = "0010";
            da7.Text = "0010";

            fetchbtn.Enabled = true;
            fetchbtn.BackColor = Color.LawnGreen;

            decodebtn.Enabled = false;
            decodebtn.BackColor = Color.Gray;
            execbtn.Enabled = false;
            execbtn.BackColor = Color.Gray;

            pc1.Text = "0";
            pc2.Text = "0";
            pc3.Text = "0";
            pc4.Text = "0";




        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void fetchbtn_Click(object sender, EventArgs e)
        {
            pc4.Text = "1";
            mar1.Text = "0";
            mar2.Text = "0";
            mar3.Text = "0";
            mar4.Text = "0";

            mdr1.Text = "0";
            mdr2.Text = "0";
            mdr3.Text = "0";
            mdr4.Text = "1";
            mdr5.Text = "1";
            mdr6.Text = "0";
            mdr7.Text = "0";
            mdr8.Text = "0";

            fetchbtn.Enabled = false;
            fetchbtn.BackColor = Color.Gray;

            decodebtn.Enabled  =true;
            decodebtn.BackColor = Color.LawnGreen;
            execbtn.Enabled = false;


        }

        private void decodebtn_Click(object sender, EventArgs e)
        {
            fetchbtn.Enabled = false;
            fetchbtn.BackColor = Color.Gray;

            decodebtn.Enabled = false;
            decodebtn.BackColor = Color.Gray;

            execbtn.Enabled = true;
            execbtn.BackColor = Color.LawnGreen;

            d1.Text = mdr1.Text;
            d1.BackColor = Color.MediumPurple;
            d2.Text = mdr2.Text;
            d2.BackColor = Color.MediumPurple;
            d3.Text = mdr3.Text;
            d3.BackColor = Color.MediumPurple;
            d4.Text = mdr4.Text;
            d4.BackColor = Color.MediumPurple;
            d5.Text = mdr5.Text;
            d5.BackColor = Color.Coral;
            d6.Text = mdr6.Text;
            d6.BackColor = Color.Coral;
            d7.Text = mdr7.Text;
            d7.BackColor = Color.Coral;
            d8.Text = mdr8.Text;
            d8.BackColor = Color.Coral;

            OpcodeLight.BackColor = Color.MediumPurple;
            OperandLight.BackColor = Color.Coral;



        }
    }
}
