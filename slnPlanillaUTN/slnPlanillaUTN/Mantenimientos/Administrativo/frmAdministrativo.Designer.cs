namespace slnPlanillaUTN.Mantenimientos.Administrativo
{
    partial class frmAdministrativo
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
            this.btnRealizarRegistro = new System.Windows.Forms.Button();
            this.btnRegistrarVacaciones = new System.Windows.Forms.Button();
            this.btnGestionarExpedientes = new System.Windows.Forms.Button();
            this.btnCalculoPlanilla = new System.Windows.Forms.Button();
            this.btnGenerarReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRealizarRegistro
            // 
            this.btnRealizarRegistro.Location = new System.Drawing.Point(12, 12);
            this.btnRealizarRegistro.Name = "btnRealizarRegistro";
            this.btnRealizarRegistro.Size = new System.Drawing.Size(166, 67);
            this.btnRealizarRegistro.TabIndex = 0;
            this.btnRealizarRegistro.Text = "Realizar Registro";
            this.btnRealizarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarVacaciones
            // 
            this.btnRegistrarVacaciones.Location = new System.Drawing.Point(12, 85);
            this.btnRegistrarVacaciones.Name = "btnRegistrarVacaciones";
            this.btnRegistrarVacaciones.Size = new System.Drawing.Size(166, 67);
            this.btnRegistrarVacaciones.TabIndex = 1;
            this.btnRegistrarVacaciones.Text = "Registrar Vacaciones";
            this.btnRegistrarVacaciones.UseVisualStyleBackColor = true;
            // 
            // btnGestionarExpedientes
            // 
            this.btnGestionarExpedientes.Location = new System.Drawing.Point(12, 158);
            this.btnGestionarExpedientes.Name = "btnGestionarExpedientes";
            this.btnGestionarExpedientes.Size = new System.Drawing.Size(166, 67);
            this.btnGestionarExpedientes.TabIndex = 2;
            this.btnGestionarExpedientes.Text = "Gestionar Expedientes";
            this.btnGestionarExpedientes.UseVisualStyleBackColor = true;
            // 
            // btnCalculoPlanilla
            // 
            this.btnCalculoPlanilla.Location = new System.Drawing.Point(12, 231);
            this.btnCalculoPlanilla.Name = "btnCalculoPlanilla";
            this.btnCalculoPlanilla.Size = new System.Drawing.Size(166, 67);
            this.btnCalculoPlanilla.TabIndex = 3;
            this.btnCalculoPlanilla.Text = "Cálculo de Planilla";
            this.btnCalculoPlanilla.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReportes
            // 
            this.btnGenerarReportes.Location = new System.Drawing.Point(12, 304);
            this.btnGenerarReportes.Name = "btnGenerarReportes";
            this.btnGenerarReportes.Size = new System.Drawing.Size(166, 67);
            this.btnGenerarReportes.TabIndex = 4;
            this.btnGenerarReportes.Text = "Generar Reportes";
            this.btnGenerarReportes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 377);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 67);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 454);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarReportes);
            this.Controls.Add(this.btnCalculoPlanilla);
            this.Controls.Add(this.btnGestionarExpedientes);
            this.Controls.Add(this.btnRegistrarVacaciones);
            this.Controls.Add(this.btnRealizarRegistro);
            this.Name = "frmAdministrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrativo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRealizarRegistro;
        private System.Windows.Forms.Button btnRegistrarVacaciones;
        private System.Windows.Forms.Button btnGestionarExpedientes;
        private System.Windows.Forms.Button btnCalculoPlanilla;
        private System.Windows.Forms.Button btnGenerarReportes;
        private System.Windows.Forms.Button btnSalir;
    }
}