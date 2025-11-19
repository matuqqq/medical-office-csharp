namespace CapaPresentacion.Forms
{
    partial class AsignarTurnoForm
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
            this.TXB_Fecha = new System.Windows.Forms.TextBox();
            this.TXB_Hora = new System.Windows.Forms.TextBox();
            this.TXB_Estado = new System.Windows.Forms.TextBox();
            this.TXB_PacienteId = new System.Windows.Forms.TextBox();
            this.TXB_MedicoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_CargarTurno = new System.Windows.Forms.Button();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.BTN_AgregarPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXB_Fecha
            // 
            this.TXB_Fecha.Location = new System.Drawing.Point(372, 106);
            this.TXB_Fecha.Name = "TXB_Fecha";
            this.TXB_Fecha.Size = new System.Drawing.Size(138, 20);
            this.TXB_Fecha.TabIndex = 0;
            // 
            // TXB_Hora
            // 
            this.TXB_Hora.Location = new System.Drawing.Point(372, 145);
            this.TXB_Hora.Name = "TXB_Hora";
            this.TXB_Hora.Size = new System.Drawing.Size(138, 20);
            this.TXB_Hora.TabIndex = 1;
            // 
            // TXB_Estado
            // 
            this.TXB_Estado.Location = new System.Drawing.Point(372, 181);
            this.TXB_Estado.Name = "TXB_Estado";
            this.TXB_Estado.Size = new System.Drawing.Size(138, 20);
            this.TXB_Estado.TabIndex = 2;
            // 
            // TXB_PacienteId
            // 
            this.TXB_PacienteId.Location = new System.Drawing.Point(372, 221);
            this.TXB_PacienteId.Name = "TXB_PacienteId";
            this.TXB_PacienteId.Size = new System.Drawing.Size(138, 20);
            this.TXB_PacienteId.TabIndex = 3;
            // 
            // TXB_MedicoId
            // 
            this.TXB_MedicoId.Location = new System.Drawing.Point(372, 258);
            this.TXB_MedicoId.Name = "TXB_MedicoId";
            this.TXB_MedicoId.Size = new System.Drawing.Size(138, 20);
            this.TXB_MedicoId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "PacienteId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "MedicoId";
            // 
            // BTN_CargarTurno
            // 
            this.BTN_CargarTurno.Location = new System.Drawing.Point(335, 322);
            this.BTN_CargarTurno.Name = "BTN_CargarTurno";
            this.BTN_CargarTurno.Size = new System.Drawing.Size(119, 23);
            this.BTN_CargarTurno.TabIndex = 10;
            this.BTN_CargarTurno.Text = "Cargar Turno";
            this.BTN_CargarTurno.UseVisualStyleBackColor = true;
            this.BTN_CargarTurno.Click += new System.EventHandler(this.BTN_CargarTurno_Click);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Location = new System.Drawing.Point(369, 428);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(37, 13);
            this.LL_Volver.TabIndex = 11;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // BTN_AgregarPaciente
            // 
            this.BTN_AgregarPaciente.Location = new System.Drawing.Point(516, 221);
            this.BTN_AgregarPaciente.Name = "BTN_AgregarPaciente";
            this.BTN_AgregarPaciente.Size = new System.Drawing.Size(22, 20);
            this.BTN_AgregarPaciente.TabIndex = 12;
            this.BTN_AgregarPaciente.Text = "+";
            this.BTN_AgregarPaciente.UseVisualStyleBackColor = true;
            this.BTN_AgregarPaciente.Click += new System.EventHandler(this.BTN_AgregarPaciente_Click);
            // 
            // AsignarTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_AgregarPaciente);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_CargarTurno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_MedicoId);
            this.Controls.Add(this.TXB_PacienteId);
            this.Controls.Add(this.TXB_Estado);
            this.Controls.Add(this.TXB_Hora);
            this.Controls.Add(this.TXB_Fecha);
            this.Name = "AsignarTurnoForm";
            this.Text = "AsignarTurnoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_Fecha;
        private System.Windows.Forms.TextBox TXB_Hora;
        private System.Windows.Forms.TextBox TXB_Estado;
        private System.Windows.Forms.TextBox TXB_PacienteId;
        private System.Windows.Forms.TextBox TXB_MedicoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_CargarTurno;
        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.Button BTN_AgregarPaciente;
    }
}