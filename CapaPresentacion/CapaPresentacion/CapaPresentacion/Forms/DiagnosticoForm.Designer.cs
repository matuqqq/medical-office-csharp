namespace CapaPresentacion.Forms
{
    partial class DiagnosticoForm
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
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.BTN_CargarDiagnostico = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_TurnoId = new System.Windows.Forms.TextBox();
            this.TXB_PacienteId = new System.Windows.Forms.TextBox();
            this.TXB_Tratamiento = new System.Windows.Forms.TextBox();
            this.RTXB_Diagnostico = new System.Windows.Forms.RichTextBox();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Location = new System.Drawing.Point(382, 428);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(37, 13);
            this.LL_Volver.TabIndex = 23;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // BTN_CargarDiagnostico
            // 
            this.BTN_CargarDiagnostico.Location = new System.Drawing.Point(341, 349);
            this.BTN_CargarDiagnostico.Name = "BTN_CargarDiagnostico";
            this.BTN_CargarDiagnostico.Size = new System.Drawing.Size(119, 23);
            this.BTN_CargarDiagnostico.TabIndex = 22;
            this.BTN_CargarDiagnostico.Text = "Cargar Diagnostico";
            this.BTN_CargarDiagnostico.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "TurnoId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "PacienteId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Diagnostico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tratamiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fecha";
            // 
            // TXB_TurnoId
            // 
            this.TXB_TurnoId.Location = new System.Drawing.Point(345, 303);
            this.TXB_TurnoId.Name = "TXB_TurnoId";
            this.TXB_TurnoId.Size = new System.Drawing.Size(138, 20);
            this.TXB_TurnoId.TabIndex = 16;
            // 
            // TXB_PacienteId
            // 
            this.TXB_PacienteId.Location = new System.Drawing.Point(349, 79);
            this.TXB_PacienteId.Name = "TXB_PacienteId";
            this.TXB_PacienteId.Size = new System.Drawing.Size(138, 20);
            this.TXB_PacienteId.TabIndex = 15;
            // 
            // TXB_Tratamiento
            // 
            this.TXB_Tratamiento.Location = new System.Drawing.Point(345, 265);
            this.TXB_Tratamiento.Name = "TXB_Tratamiento";
            this.TXB_Tratamiento.Size = new System.Drawing.Size(204, 20);
            this.TXB_Tratamiento.TabIndex = 13;
            // 
            // RTXB_Diagnostico
            // 
            this.RTXB_Diagnostico.Location = new System.Drawing.Point(345, 155);
            this.RTXB_Diagnostico.Name = "RTXB_Diagnostico";
            this.RTXB_Diagnostico.Size = new System.Drawing.Size(204, 92);
            this.RTXB_Diagnostico.TabIndex = 24;
            this.RTXB_Diagnostico.Text = "";
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Location = new System.Drawing.Point(349, 114);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(200, 20);
            this.DTP_Fecha.TabIndex = 25;
            // 
            // DiagnosticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.RTXB_Diagnostico);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_CargarDiagnostico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_TurnoId);
            this.Controls.Add(this.TXB_PacienteId);
            this.Controls.Add(this.TXB_Tratamiento);
            this.Name = "DiagnosticoForm";
            this.Text = "DiagnosticoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.Button BTN_CargarDiagnostico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_TurnoId;
        private System.Windows.Forms.TextBox TXB_PacienteId;
        private System.Windows.Forms.TextBox TXB_Tratamiento;
        private System.Windows.Forms.RichTextBox RTXB_Diagnostico;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
    }
}