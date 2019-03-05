namespace slnPlanillaUTN.Mantenimientos
{
    partial class frmExpediente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIDPuesto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIDCarrera = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIDJornada = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCProfesional = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mktFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVerExpediente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre completo del colaborador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Ingreso:";
            // 
            // cmbIDPuesto
            // 
            this.cmbIDPuesto.FormattingEnabled = true;
            this.cmbIDPuesto.Location = new System.Drawing.Point(188, 72);
            this.cmbIDPuesto.Name = "cmbIDPuesto";
            this.cmbIDPuesto.Size = new System.Drawing.Size(121, 21);
            this.cmbIDPuesto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puesto:";
            // 
            // cmbIDCarrera
            // 
            this.cmbIDCarrera.FormattingEnabled = true;
            this.cmbIDCarrera.Location = new System.Drawing.Point(188, 99);
            this.cmbIDCarrera.Name = "cmbIDCarrera";
            this.cmbIDCarrera.Size = new System.Drawing.Size(121, 21);
            this.cmbIDCarrera.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Carrera:";
            // 
            // cmbIDJornada
            // 
            this.cmbIDJornada.FormattingEnabled = true;
            this.cmbIDJornada.Location = new System.Drawing.Point(188, 126);
            this.cmbIDJornada.Name = "cmbIDJornada";
            this.cmbIDJornada.Size = new System.Drawing.Size(121, 21);
            this.cmbIDJornada.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jornada:";
            // 
            // cmbCProfesional
            // 
            this.cmbCProfesional.FormattingEnabled = true;
            this.cmbCProfesional.Location = new System.Drawing.Point(188, 153);
            this.cmbCProfesional.Name = "cmbCProfesional";
            this.cmbCProfesional.Size = new System.Drawing.Size(121, 21);
            this.cmbCProfesional.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Carrera Profesional:";
            // 
            // mktFechaIngreso
            // 
            this.mktFechaIngreso.Location = new System.Drawing.Point(188, 46);
            this.mktFechaIngreso.Mask = "00/00/0000";
            this.mktFechaIngreso.Name = "mktFechaIngreso";
            this.mktFechaIngreso.Size = new System.Drawing.Size(121, 20);
            this.mktFechaIngreso.TabIndex = 12;
            this.mktFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(16, 187);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 39);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnVerExpediente
            // 
            this.btnVerExpediente.Location = new System.Drawing.Point(164, 187);
            this.btnVerExpediente.Name = "btnVerExpediente";
            this.btnVerExpediente.Size = new System.Drawing.Size(145, 39);
            this.btnVerExpediente.TabIndex = 14;
            this.btnVerExpediente.Text = "Ver Expediente";
            this.btnVerExpediente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(100, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 46);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 16;
            // 
            // frmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 290);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerExpediente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mktFechaIngreso);
            this.Controls.Add(this.cmbCProfesional);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbIDJornada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIDCarrera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIDPuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIDPuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIDCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIDJornada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCProfesional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mktFechaIngreso;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVerExpediente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBox1;
    }
}