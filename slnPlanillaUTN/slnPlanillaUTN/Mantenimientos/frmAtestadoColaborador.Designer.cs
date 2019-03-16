namespace slnPlanillaUTN.Mantenimientos
{
    partial class frmAtestadoColaborador
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
            this.label4 = new System.Windows.Forms.Label();
            this.lstAtestados = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.rdbDiplomado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbBachillerato = new System.Windows.Forms.RadioButton();
            this.rdbEspecialidad = new System.Windows.Forms.RadioButton();
            this.rdbLicenciatura = new System.Windows.Forms.RadioButton();
            this.rdbMaestría = new System.Windows.Forms.RadioButton();
            this.rdbDoctorado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Atestados del Colaborador";
            // 
            // lstAtestados
            // 
            this.lstAtestados.FormattingEnabled = true;
            this.lstAtestados.ItemHeight = 16;
            this.lstAtestados.Location = new System.Drawing.Point(27, 81);
            this.lstAtestados.Name = "lstAtestados";
            this.lstAtestados.Size = new System.Drawing.Size(493, 228);
            this.lstAtestados.TabIndex = 8;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(65, 486);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 52);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo atestado";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(367, 486);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 50);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(224, 486);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(116, 52);
            this.btnVer.TabIndex = 11;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // rdbDiplomado
            // 
            this.rdbDiplomado.AutoSize = true;
            this.rdbDiplomado.Location = new System.Drawing.Point(79, 374);
            this.rdbDiplomado.Name = "rdbDiplomado";
            this.rdbDiplomado.Size = new System.Drawing.Size(96, 21);
            this.rdbDiplomado.TabIndex = 12;
            this.rdbDiplomado.TabStop = true;
            this.rdbDiplomado.Text = "Diplomado";
            this.rdbDiplomado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de atestado";
            // 
            // rdbBachillerato
            // 
            this.rdbBachillerato.AutoSize = true;
            this.rdbBachillerato.Location = new System.Drawing.Point(79, 401);
            this.rdbBachillerato.Name = "rdbBachillerato";
            this.rdbBachillerato.Size = new System.Drawing.Size(103, 21);
            this.rdbBachillerato.TabIndex = 14;
            this.rdbBachillerato.TabStop = true;
            this.rdbBachillerato.Text = "Bachillerato";
            this.rdbBachillerato.UseVisualStyleBackColor = true;
            // 
            // rdbEspecialidad
            // 
            this.rdbEspecialidad.AutoSize = true;
            this.rdbEspecialidad.Location = new System.Drawing.Point(209, 375);
            this.rdbEspecialidad.Name = "rdbEspecialidad";
            this.rdbEspecialidad.Size = new System.Drawing.Size(109, 21);
            this.rdbEspecialidad.TabIndex = 15;
            this.rdbEspecialidad.TabStop = true;
            this.rdbEspecialidad.Text = "Especialidad";
            this.rdbEspecialidad.UseVisualStyleBackColor = true;
            // 
            // rdbLicenciatura
            // 
            this.rdbLicenciatura.AutoSize = true;
            this.rdbLicenciatura.Location = new System.Drawing.Point(79, 428);
            this.rdbLicenciatura.Name = "rdbLicenciatura";
            this.rdbLicenciatura.Size = new System.Drawing.Size(106, 21);
            this.rdbLicenciatura.TabIndex = 16;
            this.rdbLicenciatura.TabStop = true;
            this.rdbLicenciatura.Text = "Licenciatura";
            this.rdbLicenciatura.UseVisualStyleBackColor = true;
            // 
            // rdbMaestría
            // 
            this.rdbMaestría.AutoSize = true;
            this.rdbMaestría.Location = new System.Drawing.Point(209, 401);
            this.rdbMaestría.Name = "rdbMaestría";
            this.rdbMaestría.Size = new System.Drawing.Size(83, 21);
            this.rdbMaestría.TabIndex = 17;
            this.rdbMaestría.TabStop = true;
            this.rdbMaestría.Text = "Maestría";
            this.rdbMaestría.UseVisualStyleBackColor = true;
            // 
            // rdbDoctorado
            // 
            this.rdbDoctorado.AutoSize = true;
            this.rdbDoctorado.Location = new System.Drawing.Point(209, 428);
            this.rdbDoctorado.Name = "rdbDoctorado";
            this.rdbDoctorado.Size = new System.Drawing.Size(95, 21);
            this.rdbDoctorado.TabIndex = 18;
            this.rdbDoctorado.TabStop = true;
            this.rdbDoctorado.Text = "Doctorado";
            this.rdbDoctorado.UseVisualStyleBackColor = true;
            // 
            // frmAtestadoColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 600);
            this.Controls.Add(this.rdbDoctorado);
            this.Controls.Add(this.rdbMaestría);
            this.Controls.Add(this.rdbLicenciatura);
            this.Controls.Add(this.rdbEspecialidad);
            this.Controls.Add(this.rdbBachillerato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbDiplomado);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstAtestados);
            this.Controls.Add(this.label4);
            this.Name = "frmAtestadoColaborador";
            this.Text = "frmAtestadoColaborador";
            this.Load += new System.EventHandler(this.frmAtestadoColaborador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstAtestados;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.RadioButton rdbDiplomado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbBachillerato;
        private System.Windows.Forms.RadioButton rdbEspecialidad;
        private System.Windows.Forms.RadioButton rdbLicenciatura;
        private System.Windows.Forms.RadioButton rdbMaestría;
        private System.Windows.Forms.RadioButton rdbDoctorado;
    }
}