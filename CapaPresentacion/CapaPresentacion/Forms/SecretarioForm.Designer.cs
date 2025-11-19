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
            this.button1 = new System.Windows.Forms.Button();
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 140);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver Turnos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SecretarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_AsignarTurno);
            this.Name = "SecretarioForm";
            this.Text = "SecretarioForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_AsignarTurno;
        private System.Windows.Forms.Button button1;
    }
}