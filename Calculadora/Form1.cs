using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal valor1 = 0, valor2 = 0;
        string acao = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txresultado.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txresultado.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txresultado.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txresultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txresultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txresultado.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txresultado.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txresultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txresultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txresultado.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txresultado.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txresultado.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            /*valor1 = Convert.ToDecimal(txresultado.Text);*/
            valor1 = decimal.Parse(txresultado.Text);
            
        }
    }
}
