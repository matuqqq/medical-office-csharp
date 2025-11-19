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
            this.BTN_AsignarTurno = new System.Windows.Forms.Button();
            this.BTN_VerTurnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_AsignarTurno
            // 
            this.BTN_AsignarTurno.Location = new System.Drawing.Point(155, 155);
            this.BTN_AsignarTurno.Name = "BTN_AsignarTurno";
            this.BTN_AsignarTurno.Size = new System.Drawing.Size(140, 140);
            this.BTN_AsignarTurno.TabIndex = 0;
            this.BTN_AsignarTurno.Text = "Asignar Turno";
            this.BTN_AsignarTurno.UseVisualStyleBackColor = true;
            this.BTN_AsignarTurno.Click += new System.EventHandler(this.BTN_AsignarTurno_Click);
            // 
            // BTN_VerTurnos
            // 
            this.BTN_VerTurnos.Location = new System.Drawing.Point(505, 155);
            this.BTN_VerTurnos.Name = "BTN_VerTurnos";
            this.BTN_VerTurnos.Size = new System.Drawing.Size(140, 140);
            this.BTN_VerTurnos.TabIndex = 1;
            this.BTN_VerTurnos.Text = "Ver Turnos";
            this.BTN_VerTurnos.UseVisualStyleBackColor = true;
            this.BTN_VerTurnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecretarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_VerTurnos);
            this.Controls.Add(this.BTN_AsignarTurno);
            this.Name = "SecretarioForm";
            this.Text = "SecretarioForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_AsignarTurno;
        private System.Windows.Forms.Button BTN_VerTurnos;
    }
}