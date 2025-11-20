namespace CapaPresentacion.Forms
{
    partial class MedicoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicoForm));
            this.BTN_VerHistorialClinico = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.BTN_Diagnosticar = new System.Windows.Forms.Button();
            this.BTN_VerTurno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_VerHistorialClinico
            // 
            this.BTN_VerHistorialClinico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_VerHistorialClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VerHistorialClinico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VerHistorialClinico.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_VerHistorialClinico.Location = new System.Drawing.Point(422, 187);
            this.BTN_VerHistorialClinico.Name = "BTN_VerHistorialClinico";
            this.BTN_VerHistorialClinico.Size = new System.Drawing.Size(140, 140);
            this.BTN_VerHistorialClinico.TabIndex = 9;
            this.BTN_VerHistorialClinico.Text = "Ver Historial Clinico";
            this.BTN_VerHistorialClinico.UseVisualStyleBackColor = false;
            this.BTN_VerHistorialClinico.Click += new System.EventHandler(this.BTN_VerHistorialClinico_Click_1);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Salir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Salir.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Salir.Location = new System.Drawing.Point(447, 447);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(91, 26);
            this.BTN_Salir.TabIndex = 8;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = false;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click_1);
            // 
            // BTN_Diagnosticar
            // 
            this.BTN_Diagnosticar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Diagnosticar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Diagnosticar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Diagnosticar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Diagnosticar.Location = new System.Drawing.Point(708, 187);
            this.BTN_Diagnosticar.Name = "BTN_Diagnosticar";
            this.BTN_Diagnosticar.Size = new System.Drawing.Size(140, 140);
            this.BTN_Diagnosticar.TabIndex = 7;
            this.BTN_Diagnosticar.Text = "Diagnosticar";
            this.BTN_Diagnosticar.UseVisualStyleBackColor = false;
            this.BTN_Diagnosticar.Click += new System.EventHandler(this.BTN_Diagnosticar_Click_1);
            // 
            // BTN_VerTurno
            // 
            this.BTN_VerTurno.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_VerTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VerTurno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VerTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_VerTurno.Location = new System.Drawing.Point(136, 187);
            this.BTN_VerTurno.Name = "BTN_VerTurno";
            this.BTN_VerTurno.Size = new System.Drawing.Size(140, 140);
            this.BTN_VerTurno.TabIndex = 6;
            this.BTN_VerTurno.Text = "Ver Turnos";
            this.BTN_VerTurno.UseVisualStyleBackColor = false;
            this.BTN_VerTurno.Click += new System.EventHandler(this.BTN_AsignarTurno_Click);
            // 
            // MedicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.BTN_VerHistorialClinico);
            this.Controls.Add(this.BTN_Salir);
            this.Controls.Add(this.BTN_Diagnosticar);
            this.Controls.Add(this.BTN_VerTurno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicoForm";
            this.Text = "MedicoForm";
            this.Load += new System.EventHandler(this.MedicoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_VerHistorialClinico;
        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.Button BTN_Diagnosticar;
        private System.Windows.Forms.Button BTN_VerTurno;
    }
}