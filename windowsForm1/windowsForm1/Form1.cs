﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForm1
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int input1 = Convert.ToInt32(textBox2.Text);
                int input2 = Convert.ToInt32(textBox3.Text);

                int result = input1 + input2;

                MessageBox.Show("Addition of two numbers is:" + result.ToString());
            }
            catch( Exception ex)
            {

            }
        }
    }
}
