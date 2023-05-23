using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace WindowsFormsApp11
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
        private void button2_Click(object sender, EventArgs e)
        { 
            try
            {
                int input1 = Convert.ToInt32(textBox1.Text);
                int input2 = Convert.ToInt32(textBox2.Text);

                int result = input1 + input2;

                Show("Addition:" + result.ToString());
            }
            catch(Exception ex)
            {

            }
                }
        }
    }

