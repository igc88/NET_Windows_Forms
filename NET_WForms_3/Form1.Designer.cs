
namespace NET_WForms_3 {
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rWindows = new System.Windows.Forms.RadioButton();
            this.rLinux = new System.Windows.Forms.RadioButton();
            this.rMac = new System.Windows.Forms.RadioButton();
            this.gbSo = new System.Windows.Forms.GroupBox();
            this.chProgramacion = new System.Windows.Forms.CheckBox();
            this.cbAdministracion = new System.Windows.Forms.CheckBox();
            this.cbDiseno = new System.Windows.Forms.CheckBox();
            this.gbEspecialidad = new System.Windows.Forms.GroupBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.tbHoras = new System.Windows.Forms.TrackBar();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.gbSo.SuspendLayout();
            this.gbEspecialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(351, 40);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(12, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(327, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Encuesta";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rWindows
            // 
            this.rWindows.AutoSize = true;
            this.rWindows.Font = new System.Drawing.Font("Calibri", 10F);
            this.rWindows.Location = new System.Drawing.Point(17, 26);
            this.rWindows.Name = "rWindows";
            this.rWindows.Size = new System.Drawing.Size(77, 21);
            this.rWindows.TabIndex = 1;
            this.rWindows.TabStop = true;
            this.rWindows.Text = "Windows";
            this.rWindows.UseVisualStyleBackColor = true;
            // 
            // rLinux
            // 
            this.rLinux.AutoSize = true;
            this.rLinux.Font = new System.Drawing.Font("Calibri", 10F);
            this.rLinux.Location = new System.Drawing.Point(17, 53);
            this.rLinux.Name = "rLinux";
            this.rLinux.Size = new System.Drawing.Size(55, 21);
            this.rLinux.TabIndex = 3;
            this.rLinux.TabStop = true;
            this.rLinux.Text = "Linux";
            this.rLinux.UseVisualStyleBackColor = true;
            // 
            // rMac
            // 
            this.rMac.AutoSize = true;
            this.rMac.Font = new System.Drawing.Font("Calibri", 10F);
            this.rMac.Location = new System.Drawing.Point(17, 80);
            this.rMac.Name = "rMac";
            this.rMac.Size = new System.Drawing.Size(51, 21);
            this.rMac.TabIndex = 4;
            this.rMac.TabStop = true;
            this.rMac.Text = "Mac";
            this.rMac.UseVisualStyleBackColor = true;
            // 
            // gbSo
            // 
            this.gbSo.Controls.Add(this.rLinux);
            this.gbSo.Controls.Add(this.rMac);
            this.gbSo.Controls.Add(this.rWindows);
            this.gbSo.Font = new System.Drawing.Font("Calibri", 12F);
            this.gbSo.Location = new System.Drawing.Point(0, 55);
            this.gbSo.Name = "gbSo";
            this.gbSo.Size = new System.Drawing.Size(351, 123);
            this.gbSo.TabIndex = 5;
            this.gbSo.TabStop = false;
            this.gbSo.Text = "Elige un SO:";
            // 
            // chProgramacion
            // 
            this.chProgramacion.AutoSize = true;
            this.chProgramacion.Font = new System.Drawing.Font("Calibri", 10F);
            this.chProgramacion.Location = new System.Drawing.Point(16, 31);
            this.chProgramacion.Name = "chProgramacion";
            this.chProgramacion.Size = new System.Drawing.Size(106, 21);
            this.chProgramacion.TabIndex = 6;
            this.chProgramacion.Text = "Programacion";
            this.chProgramacion.UseVisualStyleBackColor = true;
            // 
            // cbAdministracion
            // 
            this.cbAdministracion.AutoSize = true;
            this.cbAdministracion.Font = new System.Drawing.Font("Calibri", 10F);
            this.cbAdministracion.Location = new System.Drawing.Point(17, 89);
            this.cbAdministracion.Name = "cbAdministracion";
            this.cbAdministracion.Size = new System.Drawing.Size(111, 21);
            this.cbAdministracion.TabIndex = 7;
            this.cbAdministracion.Text = "Administración";
            this.cbAdministracion.UseVisualStyleBackColor = true;
            // 
            // cbDiseno
            // 
            this.cbDiseno.AutoSize = true;
            this.cbDiseno.Font = new System.Drawing.Font("Calibri", 10F);
            this.cbDiseno.Location = new System.Drawing.Point(16, 60);
            this.cbDiseno.Name = "cbDiseno";
            this.cbDiseno.Size = new System.Drawing.Size(109, 21);
            this.cbDiseno.TabIndex = 8;
            this.cbDiseno.Text = "Diseño Gráfico";
            this.cbDiseno.UseVisualStyleBackColor = true;
            // 
            // gbEspecialidad
            // 
            this.gbEspecialidad.Controls.Add(this.chProgramacion);
            this.gbEspecialidad.Controls.Add(this.cbAdministracion);
            this.gbEspecialidad.Controls.Add(this.cbDiseno);
            this.gbEspecialidad.Font = new System.Drawing.Font("Calibri", 12F);
            this.gbEspecialidad.Location = new System.Drawing.Point(0, 184);
            this.gbEspecialidad.Name = "gbEspecialidad";
            this.gbEspecialidad.Size = new System.Drawing.Size(351, 132);
            this.gbEspecialidad.TabIndex = 9;
            this.gbEspecialidad.TabStop = false;
            this.gbEspecialidad.Text = "Elige tu especialidad";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblHoras.Location = new System.Drawing.Point(14, 333);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(251, 19);
            this.lblHoras.TabIndex = 10;
            this.lblHoras.Text = "¿Cuántas horas dedicas a usar el PC?";
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(24, 355);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(241, 45);
            this.tbHoras.TabIndex = 11;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnEnviar.Location = new System.Drawing.Point(130, 418);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(104, 36);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 466);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.gbEspecialidad);
            this.Controls.Add(this.gbSo);
            this.Controls.Add(this.pnlTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 505);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(367, 505);
            this.Name = "Form1";
            this.Text = "NET: Windows Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTitle.ResumeLayout(false);
            this.gbSo.ResumeLayout(false);
            this.gbSo.PerformLayout();
            this.gbEspecialidad.ResumeLayout(false);
            this.gbEspecialidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rWindows;
        private System.Windows.Forms.RadioButton rLinux;
        private System.Windows.Forms.RadioButton rMac;
        private System.Windows.Forms.GroupBox gbSo;
        private System.Windows.Forms.CheckBox chProgramacion;
        private System.Windows.Forms.CheckBox cbAdministracion;
        private System.Windows.Forms.CheckBox cbDiseno;
        private System.Windows.Forms.GroupBox gbEspecialidad;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TrackBar tbHoras;
        private System.Windows.Forms.Button btnEnviar;
    }
}

