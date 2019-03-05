namespace slnPlanillaUTN.Mantenimientos.Director
{
    partial class frmDirector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAprobarVacaciones = new System.Windows.Forms.Button();
            this.btnIncluirJornada = new System.Windows.Forms.Button();
            this.btnGenerarReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAprobarVacaciones
            // 
            this.btnAprobarVacaciones.Location = new System.Drawing.Point(12, 12);
            this.btnAprobarVacaciones.Name = "btnAprobarVacaciones";
            this.btnAprobarVacaciones.Size = new System.Drawing.Size(151, 67);
            this.btnAprobarVacaciones.TabIndex = 0;
            this.btnAprobarVacaciones.Text = "Aprobar Vacaciones";
            this.btnAprobarVacaciones.UseVisualStyleBackColor = true;
            // 
            // btnIncluirJornada
            // 
            this.btnIncluirJornada.Location = new System.Drawing.Point(12, 85);
            this.btnIncluirJornada.Name = "btnIncluirJornada";
            this.btnIncluirJornada.Size = new System.Drawing.Size(151, 67);
            this.btnIncluirJornada.TabIndex = 1;
            this.btnIncluirJornada.Text = "Incluir Jornada Laboral";
            this.btnIncluirJornada.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReportes
            // 
            this.btnGenerarReportes.Location = new System.Drawing.Point(12, 158);
            this.btnGenerarReportes.Name = "btnGenerarReportes";
            this.btnGenerarReportes.Size = new System.Drawing.Size(151, 67);
            this.btnGenerarReportes.TabIndex = 2;
            this.btnGenerarReportes.Text = "Generar Reportes";
            this.btnGenerarReportes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 67);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 316);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarReportes);
            this.Controls.Add(this.btnIncluirJornada);
            this.Controls.Add(this.btnAprobarVacaciones);
            this.Name = "Director";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Director";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAprobarVacaciones;
        private System.Windows.Forms.Button btnIncluirJornada;
        private System.Windows.Forms.Button btnGenerarReportes;
        private System.Windows.Forms.Button btnSalir;
    }
}