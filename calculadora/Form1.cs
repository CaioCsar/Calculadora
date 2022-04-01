using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void um_Click(object sender, EventArgs e)
        {
            result.Text += "1";
        }

        private void dois_Click(object sender, EventArgs e)
        {
            result.Text += "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            result.Text += "3";
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            result.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            result.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            result.Text += "6";
        }

        private void sete_Click(object sender, EventArgs e)
        {
            result.Text += "7";
        }

        private void oito_Click(object sender, EventArgs e)
        {
            result.Text += "8";
        }

        private void nove_Click(object sender, EventArgs e)
        {
            result.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            result.Text += "0";
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            result.Clear();
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            result.Text += ",";
        }

        string operador = "";
        string temporario = "";
        private void soma_Click(object sender, EventArgs e)
        {
            operador = "+";
            temporario = result.Text;
            result.Clear();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            operador = "-";
            temporario = result.Text;
            result.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            operador = "/";
            temporario = result.Text;
            result.Clear();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            operador = "*";
            temporario = result.Text;
            result.Clear();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            double res = 0;

            switch (operador)
            {
                case "+":
                    res = double.Parse(temporario) + double.Parse(result.Text);
                    result.Text = res.ToString();
                    break;
                case "-":
                    res = double.Parse(temporario) - double.Parse(result.Text);
                    result.Text = res.ToString();
                    break;
                case "/":
                    res = double.Parse(temporario) / double.Parse(result.Text);
                    result.Text = res.ToString();
                    break;
                case "*":
                    res = double.Parse(temporario) * double.Parse(result.Text);
                    result.Text = res.ToString();
                    break;
            }
        }
    }
}
