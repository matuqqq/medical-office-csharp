namespace CapaPresentacion.Forms
{
    partial class SecretarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretarioForm));
            this.BTN_AsignarTurno = new System.Windows.Forms.Button();
            this.BTN_VerTurnos = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.BTN_VerHistorialClinico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_AsignarTurno
            // 
            this.BTN_AsignarTurno.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_AsignarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AsignarTurno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AsignarTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_AsignarTurno.Location = new System.Drawing.Point(136, 189);
            this.BTN_AsignarTurno.Name = "BTN_AsignarTurno";
            this.BTN_AsignarTurno.Size = new System.Drawing.Size(140, 140);
            this.BTN_AsignarTurno.TabIndex = 0;
            this.BTN_AsignarTurno.Text = "Asignar Turno";
            this.BTN_AsignarTurno.UseVisualStyleBackColor = false;
            this.BTN_AsignarTurno.Click += new System.EventHandler(this.BTN_AsignarTurno_Click);
            // 
            // BTN_VerTurnos
            // 
            this.BTN_VerTurnos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_VerTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VerTurnos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VerTurnos.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_VerTurnos.Location = new System.Drawing.Point(708, 189);
            this.BTN_VerTurnos.Name = "BTN_VerTurnos";
            this.BTN_VerTurnos.Size = new System.Drawing.Size(140, 140);
            this.BTN_VerTurnos.TabIndex = 1;
            this.BTN_VerTurnos.Text = "Ver Turnos";
            this.BTN_VerTurnos.UseVisualStyleBackColor = false;
            this.BTN_VerTurnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Salir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Salir.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Salir.Location = new System.Drawing.Point(447, 449);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(91, 26);
            this.BTN_Salir.TabIndex = 4;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = false;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // BTN_VerHistorialClinico
            // 
            this.BTN_VerHistorialClinico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_VerHistorialClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VerHistorialClinico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VerHistorialClinico.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_VerHistorialClinico.Location = new System.Drawing.Point(422, 189);
            this.BTN_VerHistorialClinico.Name = "BTN_VerHistorialClinico";
            this.BTN_VerHistorialClinico.Size = new System.Drawing.Size(140, 140);
            this.BTN_VerHistorialClinico.TabIndex = 5;
            this.BTN_VerHistorialClinico.Text = "Ver Historial Clinico";
            this.BTN_VerHistorialClinico.UseVisualStyleBackColor = false;
            this.BTN_VerHistorialClinico.Click += new System.EventHandler(this.BTN_VerHistorialClinico_Click);
            // 
            // SecretarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.BTN_VerHistorialClinico);
            this.Controls.Add(this.BTN_Salir);
            this.Controls.Add(this.BTN_VerTurnos);
            this.Controls.Add(this.BTN_AsignarTurno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecretarioForm";
            this.Text = "SecretarioForm";
            this.Load += new System.EventHandler(this.SecretarioForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_AsignarTurno;
        private System.Windows.Forms.Button BTN_VerTurnos;
        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.Button BTN_VerHistorialClinico;
    }
}