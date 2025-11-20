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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticoForm));
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
            this.LL_Volver.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_Volver.LinkColor = System.Drawing.SystemColors.Control;
            this.LL_Volver.Location = new System.Drawing.Point(469, 524);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(47, 17);
            this.LL_Volver.TabIndex = 23;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // BTN_CargarDiagnostico
            // 
            this.BTN_CargarDiagnostico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_CargarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CargarDiagnostico.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CargarDiagnostico.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_CargarDiagnostico.Location = new System.Drawing.Point(416, 419);
            this.BTN_CargarDiagnostico.Name = "BTN_CargarDiagnostico";
            this.BTN_CargarDiagnostico.Size = new System.Drawing.Size(153, 28);
            this.BTN_CargarDiagnostico.TabIndex = 22;
            this.BTN_CargarDiagnostico.Text = "Cargar Diagnostico";
            this.BTN_CargarDiagnostico.UseVisualStyleBackColor = false;
            this.BTN_CargarDiagnostico.Click += new System.EventHandler(this.BTN_CargarDiagnostico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(340, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "TurnoId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(331, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "PacienteId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(325, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Diagnostico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(326, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tratamiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(358, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fecha";
            // 
            // TXB_TurnoId
            // 
            this.TXB_TurnoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_TurnoId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_TurnoId.Location = new System.Drawing.Point(437, 374);
            this.TXB_TurnoId.Name = "TXB_TurnoId";
            this.TXB_TurnoId.Size = new System.Drawing.Size(204, 25);
            this.TXB_TurnoId.TabIndex = 16;
            // 
            // TXB_PacienteId
            // 
            this.TXB_PacienteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_PacienteId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_PacienteId.Location = new System.Drawing.Point(441, 149);
            this.TXB_PacienteId.Name = "TXB_PacienteId";
            this.TXB_PacienteId.Size = new System.Drawing.Size(200, 25);
            this.TXB_PacienteId.TabIndex = 15;
            // 
            // TXB_Tratamiento
            // 
            this.TXB_Tratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_Tratamiento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Tratamiento.Location = new System.Drawing.Point(437, 334);
            this.TXB_Tratamiento.Name = "TXB_Tratamiento";
            this.TXB_Tratamiento.Size = new System.Drawing.Size(204, 25);
            this.TXB_Tratamiento.TabIndex = 13;
            // 
            // RTXB_Diagnostico
            // 
            this.RTXB_Diagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTXB_Diagnostico.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTXB_Diagnostico.Location = new System.Drawing.Point(437, 225);
            this.RTXB_Diagnostico.Name = "RTXB_Diagnostico";
            this.RTXB_Diagnostico.Size = new System.Drawing.Size(204, 92);
            this.RTXB_Diagnostico.TabIndex = 24;
            this.RTXB_Diagnostico.Text = "";
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Fecha.CalendarForeColor = System.Drawing.SystemColors.Control;
            this.DTP_Fecha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Fecha.Location = new System.Drawing.Point(441, 187);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(200, 20);
            this.DTP_Fecha.TabIndex = 25;
            // 
            // DiagnosticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(984, 661);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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