using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        //variables 
        string operador = "";
        double num1 = 0; 
        double num2 = 0;

        private void clear_Click_1(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(txtScreen.TextLength == 1) txtScreen.Text = "0";
            else txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";    
            txtScreen.Text = txtScreen.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtScreen.Text);

            switch (operador)
            {
                case "+":
                    txtScreen.Text = $" {num1 + num2}";
                    break;
                case "-":
                    txtScreen.Text = $" {num1 - num2}";
                    break;
                case "*":
                    txtScreen.Text = $" {num1 * num2}";
                    break;
                case "/":
                    txtScreen.Text = $" {num1 / num2}";
                    break;

            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
