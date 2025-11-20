namespace CapaPresentacion.Forms
{
    partial class ActualizarTurno
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
            this.BTN_ActualizarTurno = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_MedicoId = new System.Windows.Forms.TextBox();
            this.TXB_Hora = new System.Windows.Forms.TextBox();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.CHB_Completado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_Volver.LinkColor = System.Drawing.SystemColors.Control;
            this.LL_Volver.Location = new System.Drawing.Point(472, 437);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(47, 17);
            this.LL_Volver.TabIndex = 24;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // BTN_ActualizarTurno
            // 
            this.BTN_ActualizarTurno.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_ActualizarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ActualizarTurno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ActualizarTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_ActualizarTurno.Location = new System.Drawing.Point(425, 395);
            this.BTN_ActualizarTurno.Name = "BTN_ActualizarTurno";
            this.BTN_ActualizarTurno.Size = new System.Drawing.Size(134, 28);
            this.BTN_ActualizarTurno.TabIndex = 23;
            this.BTN_ActualizarTurno.Text = "Actualizar Turno";
            this.BTN_ActualizarTurno.UseVisualStyleBackColor = false;
            this.BTN_ActualizarTurno.Click += new System.EventHandler(this.BTN_ActualizarTurno_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(353, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "MedicoId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(362, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(371, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(366, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha";
            // 
            // TXB_MedicoId
            // 
            this.TXB_MedicoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_MedicoId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_MedicoId.Location = new System.Drawing.Point(439, 346);
            this.TXB_MedicoId.Name = "TXB_MedicoId";
            this.TXB_MedicoId.Size = new System.Drawing.Size(138, 25);
            this.TXB_MedicoId.TabIndex = 17;
            // 
            // TXB_Hora
            // 
            this.TXB_Hora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_Hora.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Hora.Location = new System.Drawing.Point(438, 274);
            this.TXB_Hora.Name = "TXB_Hora";
            this.TXB_Hora.Size = new System.Drawing.Size(138, 25);
            this.TXB_Hora.TabIndex = 14;
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Fecha.Location = new System.Drawing.Point(438, 236);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(200, 21);
            this.DTP_Fecha.TabIndex = 28;
            // 
            // CHB_Completado
            // 
            this.CHB_Completado.AutoSize = true;
            this.CHB_Completado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_Completado.ForeColor = System.Drawing.SystemColors.Control;
            this.CHB_Completado.Location = new System.Drawing.Point(438, 313);
            this.CHB_Completado.Name = "CHB_Completado";
            this.CHB_Completado.Size = new System.Drawing.Size(106, 21);
            this.CHB_Completado.TabIndex = 29;
            this.CHB_Completado.Text = "Completado";
            this.CHB_Completado.UseVisualStyleBackColor = true;
            // 
            // ActualizarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.CHB_Completado);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_ActualizarTurno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_MedicoId);
            this.Controls.Add(this.TXB_Hora);
            this.Name = "ActualizarTurno";
            this.Text = "ActualizarTurno";
            this.Load += new System.EventHandler(this.ActualizarTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.Button BTN_ActualizarTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_MedicoId;
        private System.Windows.Forms.TextBox TXB_Hora;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
        private System.Windows.Forms.CheckBox CHB_Completado;
    }
}