using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string calc;
        private void um_Click(object sender, EventArgs e)
        {
            calc += "1";
            resultado.Text = calc;
        }

        private void dois_Click(object sender, EventArgs e)
        {
            calc += "2";
            resultado.Text = calc;
        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            calc += "-";
            resultado.Text = calc;
        }

        private void igual_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            var v = dt.Compute(calc, "");
            resultado.Text = Convert.ToString(v);
            calc = Convert.ToString(v);
        }

        private void tres_Click(object sender, EventArgs e)
        {
            calc += "3";
            resultado.Text = calc;
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            calc += "4";
            resultado.Text = calc;
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            calc += "5";
            resultado.Text = calc;
        }

        private void seis_Click(object sender, EventArgs e)
        {
            calc += "6";
            resultado.Text = calc;
        }

        private void sete_Click(object sender, EventArgs e)
        {
            calc += "7";
            resultado.Text = calc;
        }

        private void oito_Click(object sender, EventArgs e)
        {
            calc += "8";
            resultado.Text = calc;
        }

        private void nove_Click(object sender, EventArgs e)
        {
            calc += "9";
            resultado.Text = calc;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            calc += "0";
            resultado.Text = calc;
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            calc += "+";
            resultado.Text = calc;
        }
    }
}
