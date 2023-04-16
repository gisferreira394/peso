using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace peso
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        string homem, mulher;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Text == mulher)
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) * 62.1 - 44.7).ToString();
            }


            else
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) * 72.7 - 58).ToString();
            }

        }
    }
}
