using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Form1 : Form {
        private double op1;
        private double op2;

        private string sign;
        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e) { }

        private void btnZero_Click(object sender, EventArgs e) {
            if (txtPantalla.Text == string.Empty) {
                txtPantalla.Text = "0";
            } else {
                txtPantalla.Text += "0";
            }
        }

        private void btnOne_Click(object sender, EventArgs e) {
            txtPantalla.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e) {
            txtPantalla.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e) {
            txtPantalla.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e) {
            txtPantalla.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e) {
            txtPantalla.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e) {
            txtPantalla.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e) {
            txtPantalla.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e) {
            txtPantalla.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e) {
            txtPantalla.Text += "9";
        }

        private void btnSum_Click(object sender, EventArgs e) {
            op1 = double.Parse(txtPantalla.Text);
            sign = "+";

            txtPantalla.Clear();
        }

        private void btnRest_Click(object sender, EventArgs e) {
            op1 = double.Parse(txtPantalla.Text);
            sign = "-";

            txtPantalla.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e) {
            op1 = double.Parse(txtPantalla.Text);
            sign = "*";

            txtPantalla.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e) {
            op1 = double.Parse(txtPantalla.Text);
            sign = "/";

            txtPantalla.Clear();
        }

        private void btnDecimal_Click(object sender, EventArgs e) {
            txtPantalla.Text += ",";
        }

        private void btnResult_Click(object sender, EventArgs e) {
            op2 = double.Parse(txtPantalla.Text);

            switch (sign) {
                case "+":
                    txtPantalla.Text = (op1 + op2).ToString();
                    break;
                case "-":
                    txtPantalla.Text = (op1 - op2).ToString();
                    break;
                case "*":
                    txtPantalla.Text = (op1 * op2).ToString();
                    break;
                case "/":
                    txtPantalla.Text = (op1 / op2).ToString();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            op1 = 0;
            op2 = 0;
            sign = string.Empty;
            txtPantalla.Text = string.Empty;
        }
    }
}
