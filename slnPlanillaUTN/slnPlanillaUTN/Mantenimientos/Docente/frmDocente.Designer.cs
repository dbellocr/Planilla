namespace slnPlanillaUTN.Mantenimientos.Docente
{
    partial class frmDocente
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
            this.btnVerExpediente = new System.Windows.Forms.Button();
            this.btnActualizarExpediente = new System.Windows.Forms.Button();
            this.btnSolicitarVacaciones = new System.Windows.Forms.Button();
            this.btnSolicitarReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerExpediente
            // 
            this.btnVerExpediente.Location = new System.Drawing.Point(32, 15);
            this.btnVerExpediente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerExpediente.Name = "btnVerExpediente";
            this.btnVerExpediente.Size = new System.Drawing.Size(208, 71);
            this.btnVerExpediente.TabIndex = 0;
            this.btnVerExpediente.Text = "Ver Expediente";
            this.btnVerExpediente.UseVisualStyleBackColor = true;
            this.btnVerExpediente.Click += new System.EventHandler(this.btnVerExpediente_Click);
            // 
            // btnActualizarExpediente
            // 
            this.btnActualizarExpediente.Location = new System.Drawing.Point(32, 94);
            this.btnActualizarExpediente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarExpediente.Name = "btnActualizarExpediente";
            this.btnActualizarExpediente.Size = new System.Drawing.Size(208, 71);
            this.btnActualizarExpediente.TabIndex = 1;
            this.btnActualizarExpediente.Text = "Actualizar Expediente";
            this.btnActualizarExpediente.UseVisualStyleBackColor = true;
            // 
            // btnSolicitarVacaciones
            // 
            this.btnSolicitarVacaciones.Location = new System.Drawing.Point(32, 172);
            this.btnSolicitarVacaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSolicitarVacaciones.Name = "btnSolicitarVacaciones";
            this.btnSolicitarVacaciones.Size = new System.Drawing.Size(208, 71);
            this.btnSolicitarVacaciones.TabIndex = 2;
            this.btnSolicitarVacaciones.Text = "Solicitar Vacaciones";
            this.btnSolicitarVacaciones.UseVisualStyleBackColor = true;
            // 
            // btnSolicitarReportes
            // 
            this.btnSolicitarReportes.Location = new System.Drawing.Point(32, 251);
            this.btnSolicitarReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSolicitarReportes.Name = "btnSolicitarReportes";
            this.btnSolicitarReportes.Size = new System.Drawing.Size(208, 71);
            this.btnSolicitarReportes.TabIndex = 3;
            this.btnSolicitarReportes.Text = "Solicitar Reportes";
            this.btnSolicitarReportes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(32, 330);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 71);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 420);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSolicitarReportes);
            this.Controls.Add(this.btnSolicitarVacaciones);
            this.Controls.Add(this.btnActualizarExpediente);
            this.Controls.Add(this.btnVerExpediente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerExpediente;
        private System.Windows.Forms.Button btnActualizarExpediente;
        private System.Windows.Forms.Button btnSolicitarVacaciones;
        private System.Windows.Forms.Button btnSolicitarReportes;
        private System.Windows.Forms.Button btnSalir;
    }
}