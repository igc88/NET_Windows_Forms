using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_WForms_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            cmbPeliculas.Items.Add("El señor de los anillos");
            cmbPeliculas.Items.Add("2001: Una odisea en el espacio");

            cmbPeliculas.SelectedIndex = cmbPeliculas.Items.Count - 1;
        }

        private void btnAddPelicula_Click(object sender, EventArgs e) {
            cmbPeliculas.Items.Add(txtAddPelicula.Text);

            txtAddPelicula.Text = string.Empty;

            cmbPeliculas.SelectedIndex = cmbPeliculas.Items.Count - 1;
        }
    }
}
