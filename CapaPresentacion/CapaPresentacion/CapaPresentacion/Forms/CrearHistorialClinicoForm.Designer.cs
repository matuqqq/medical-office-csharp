namespace CapaPresentacion.Forms
{
    partial class CrearHistorialClinicoForm
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
            this.BTN_Crear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.TXB_dni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Crear
            // 
            this.BTN_Crear.Location = new System.Drawing.Point(331, 234);
            this.BTN_Crear.Name = "BTN_Crear";
            this.BTN_Crear.Size = new System.Drawing.Size(75, 23);
            this.BTN_Crear.TabIndex = 6;
            this.BTN_Crear.Text = "Crear";
            this.BTN_Crear.UseVisualStyleBackColor = true;
            this.BTN_Crear.Click += new System.EventHandler(this.BTN_Crear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de creacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Location = new System.Drawing.Point(351, 194);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(200, 20);
            this.DTP_Fecha.TabIndex = 7;
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Location = new System.Drawing.Point(348, 428);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(37, 13);
            this.LL_Volver.TabIndex = 8;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "DNI paciente";
            // 
            // TXB_dni
            // 
            this.TXB_dni.Location = new System.Drawing.Point(351, 165);
            this.TXB_dni.Name = "TXB_dni";
            this.TXB_dni.Size = new System.Drawing.Size(100, 20);
            this.TXB_dni.TabIndex = 50;
            // 
            // CrearHistorialClinicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXB_dni);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.BTN_Crear);
            this.Controls.Add(this.label1);
            this.Name = "CrearHistorialClinicoForm";
            this.Text = "CrearHistorialClinicoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Crear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXB_dni;
    }
}