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
            this.BTN_VerTurno = new System.Windows.Forms.Button();
            this.BTN_Diagnosticar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_VerTurno
            // 
            this.BTN_VerTurno.Location = new System.Drawing.Point(135, 155);
            this.BTN_VerTurno.Name = "BTN_VerTurno";
            this.BTN_VerTurno.Size = new System.Drawing.Size(140, 140);
            this.BTN_VerTurno.TabIndex = 0;
            this.BTN_VerTurno.Text = "Ver Turnos";
            this.BTN_VerTurno.UseVisualStyleBackColor = true;
            this.BTN_VerTurno.Click += new System.EventHandler(this.BTN_VerTurno_Click);
            // 
            // BTN_Diagnosticar
            // 
            this.BTN_Diagnosticar.Location = new System.Drawing.Point(525, 155);
            this.BTN_Diagnosticar.Name = "BTN_Diagnosticar";
            this.BTN_Diagnosticar.Size = new System.Drawing.Size(140, 140);
            this.BTN_Diagnosticar.TabIndex = 1;
            this.BTN_Diagnosticar.Text = "Diagnosticar";
            this.BTN_Diagnosticar.UseVisualStyleBackColor = true;
            this.BTN_Diagnosticar.Click += new System.EventHandler(this.BTN_Diagnosticar_Click);
            // 
            // MedicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Diagnosticar);
            this.Controls.Add(this.BTN_VerTurno);
            this.Name = "MedicoForm";
            this.Text = "MedicoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_VerTurno;
        private System.Windows.Forms.Button BTN_Diagnosticar;
    }
}