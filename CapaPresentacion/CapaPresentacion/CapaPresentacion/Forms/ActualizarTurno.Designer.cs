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
            this.TXB_Estado = new System.Windows.Forms.TextBox();
            this.TXB_Hora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXB_TurnoId = new System.Windows.Forms.TextBox();
            this.BTN_BuscarTurno = new System.Windows.Forms.Button();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Location = new System.Drawing.Point(358, 415);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(37, 13);
            this.LL_Volver.TabIndex = 24;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            // 
            // BTN_ActualizarTurno
            // 
            this.BTN_ActualizarTurno.Location = new System.Drawing.Point(324, 338);
            this.BTN_ActualizarTurno.Name = "BTN_ActualizarTurno";
            this.BTN_ActualizarTurno.Size = new System.Drawing.Size(119, 23);
            this.BTN_ActualizarTurno.TabIndex = 23;
            this.BTN_ActualizarTurno.Text = "Actualizar Turno";
            this.BTN_ActualizarTurno.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "MedicoId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha";
            // 
            // TXB_MedicoId
            // 
            this.TXB_MedicoId.Location = new System.Drawing.Point(361, 245);
            this.TXB_MedicoId.Name = "TXB_MedicoId";
            this.TXB_MedicoId.Size = new System.Drawing.Size(138, 20);
            this.TXB_MedicoId.TabIndex = 17;
            // 
            // TXB_Estado
            // 
            this.TXB_Estado.Location = new System.Drawing.Point(361, 209);
            this.TXB_Estado.Name = "TXB_Estado";
            this.TXB_Estado.Size = new System.Drawing.Size(138, 20);
            this.TXB_Estado.TabIndex = 15;
            // 
            // TXB_Hora
            // 
            this.TXB_Hora.Location = new System.Drawing.Point(361, 173);
            this.TXB_Hora.Name = "TXB_Hora";
            this.TXB_Hora.Size = new System.Drawing.Size(138, 20);
            this.TXB_Hora.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "ID Turno";
            // 
            // TXB_TurnoId
            // 
            this.TXB_TurnoId.Location = new System.Drawing.Point(361, 99);
            this.TXB_TurnoId.Name = "TXB_TurnoId";
            this.TXB_TurnoId.Size = new System.Drawing.Size(138, 20);
            this.TXB_TurnoId.TabIndex = 25;
            this.TXB_TurnoId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTN_BuscarTurno
            // 
            this.BTN_BuscarTurno.Location = new System.Drawing.Point(324, 287);
            this.BTN_BuscarTurno.Name = "BTN_BuscarTurno";
            this.BTN_BuscarTurno.Size = new System.Drawing.Size(119, 23);
            this.BTN_BuscarTurno.TabIndex = 27;
            this.BTN_BuscarTurno.Text = "Buscar Turno";
            this.BTN_BuscarTurno.UseVisualStyleBackColor = true;
            this.BTN_BuscarTurno.Click += new System.EventHandler(this.BTN_BuscarTurno_Click);
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Location = new System.Drawing.Point(361, 134);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(200, 20);
            this.DTP_Fecha.TabIndex = 28;
            // 
            // ActualizarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.BTN_BuscarTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXB_TurnoId);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_ActualizarTurno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_MedicoId);
            this.Controls.Add(this.TXB_Estado);
            this.Controls.Add(this.TXB_Hora);
            this.Name = "ActualizarTurno";
            this.Text = "ActualizarTurno";
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
        private System.Windows.Forms.TextBox TXB_Estado;
        private System.Windows.Forms.TextBox TXB_Hora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXB_TurnoId;
        private System.Windows.Forms.Button BTN_BuscarTurno;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
    }
}