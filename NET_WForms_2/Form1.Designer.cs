
namespace NET_WForms_2 {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtAddPelicula = new System.Windows.Forms.TextBox();
            this.cmbPeliculas = new System.Windows.Forms.ComboBox();
            this.lblList = new System.Windows.Forms.Label();
            this.btnAddPelicula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(57, 37);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(112, 20);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Añadir película";
            // 
            // txtAddPelicula
            // 
            this.txtAddPelicula.Location = new System.Drawing.Point(16, 69);
            this.txtAddPelicula.Name = "txtAddPelicula";
            this.txtAddPelicula.Size = new System.Drawing.Size(196, 20);
            this.txtAddPelicula.TabIndex = 1;
            // 
            // cmbPeliculas
            // 
            this.cmbPeliculas.FormattingEnabled = true;
            this.cmbPeliculas.Location = new System.Drawing.Point(275, 69);
            this.cmbPeliculas.Name = "cmbPeliculas";
            this.cmbPeliculas.Size = new System.Drawing.Size(221, 21);
            this.cmbPeliculas.TabIndex = 2;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(331, 37);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(154, 20);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "Peliculas disponibles";
            // 
            // btnAddPelicula
            // 
            this.btnAddPelicula.Location = new System.Drawing.Point(61, 95);
            this.btnAddPelicula.Name = "btnAddPelicula";
            this.btnAddPelicula.Size = new System.Drawing.Size(108, 23);
            this.btnAddPelicula.TabIndex = 4;
            this.btnAddPelicula.Text = "Añadir";
            this.btnAddPelicula.UseVisualStyleBackColor = true;
            this.btnAddPelicula.Click += new System.EventHandler(this.btnAddPelicula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 170);
            this.Controls.Add(this.btnAddPelicula);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.cmbPeliculas);
            this.Controls.Add(this.txtAddPelicula);
            this.Controls.Add(this.lblAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtAddPelicula;
        private System.Windows.Forms.ComboBox cmbPeliculas;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnAddPelicula;
    }
}

