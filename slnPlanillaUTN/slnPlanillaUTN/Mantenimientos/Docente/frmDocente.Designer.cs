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
            this.btnVerExpediente.Location = new System.Drawing.Point(24, 12);
            this.btnVerExpediente.Name = "btnVerExpediente";
            this.btnVerExpediente.Size = new System.Drawing.Size(156, 58);
            this.btnVerExpediente.TabIndex = 0;
            this.btnVerExpediente.Text = "Ver Expediente";
            this.btnVerExpediente.UseVisualStyleBackColor = true;
            // 
            // btnActualizarExpediente
            // 
            this.btnActualizarExpediente.Location = new System.Drawing.Point(24, 76);
            this.btnActualizarExpediente.Name = "btnActualizarExpediente";
            this.btnActualizarExpediente.Size = new System.Drawing.Size(156, 58);
            this.btnActualizarExpediente.TabIndex = 1;
            this.btnActualizarExpediente.Text = "Actualizar Expediente";
            this.btnActualizarExpediente.UseVisualStyleBackColor = true;
            // 
            // btnSolicitarVacaciones
            // 
            this.btnSolicitarVacaciones.Location = new System.Drawing.Point(24, 140);
            this.btnSolicitarVacaciones.Name = "btnSolicitarVacaciones";
            this.btnSolicitarVacaciones.Size = new System.Drawing.Size(156, 58);
            this.btnSolicitarVacaciones.TabIndex = 2;
            this.btnSolicitarVacaciones.Text = "Solicitar Vacaciones";
            this.btnSolicitarVacaciones.UseVisualStyleBackColor = true;
            // 
            // btnSolicitarReportes
            // 
            this.btnSolicitarReportes.Location = new System.Drawing.Point(24, 204);
            this.btnSolicitarReportes.Name = "btnSolicitarReportes";
            this.btnSolicitarReportes.Size = new System.Drawing.Size(156, 58);
            this.btnSolicitarReportes.TabIndex = 3;
            this.btnSolicitarReportes.Text = "Solicitar Reportes";
            this.btnSolicitarReportes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(24, 268);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // MantenimientoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 341);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSolicitarReportes);
            this.Controls.Add(this.btnSolicitarVacaciones);
            this.Controls.Add(this.btnActualizarExpediente);
            this.Controls.Add(this.btnVerExpediente);
            this.Name = "MantenimientoDocente";
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