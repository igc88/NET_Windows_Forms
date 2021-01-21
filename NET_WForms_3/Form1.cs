using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_WForms_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e) {
            string result = string.Empty;

            result += "Sistema operativo: ";

            foreach(RadioButton rb in gbSo.Controls) {
                if (rb.Checked) result += rb.Text;
            }

            result += "\n";

            result += "Especialidad: ";

            foreach (CheckBox ch in gbEspecialidad.Controls) {
                if (ch.Checked) result += ch.Text + " ";
            }

            result += "\n";

            result += "Horas: " + tbHoras.Value;

            MessageBox.Show(result);
        }
    }
}
