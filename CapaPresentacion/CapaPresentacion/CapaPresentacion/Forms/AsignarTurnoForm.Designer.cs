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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarTurnoForm));
            this.TXB_Hora = new System.Windows.Forms.TextBox();
            this.TXB_PacienteId = new System.Windows.Forms.TextBox();
            this.TXB_MedicoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_CargarTurno = new System.Windows.Forms.Button();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.BTN_AgregarPaciente = new System.Windows.Forms.Button();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.BTN_VerPacientes = new System.Windows.Forms.Button();
            this.BTN_VerMedicos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXB_Hora
            // 
            this.TXB_Hora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_Hora.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Hora.Location = new System.Drawing.Point(409, 281);
            this.TXB_Hora.Name = "TXB_Hora";
            this.TXB_Hora.Size = new System.Drawing.Size(138, 25);
            this.TXB_Hora.TabIndex = 1;
            // 
            // TXB_PacienteId
            // 
            this.TXB_PacienteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_PacienteId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_PacienteId.Location = new System.Drawing.Point(409, 314);
            this.TXB_PacienteId.Name = "TXB_PacienteId";
            this.TXB_PacienteId.Size = new System.Drawing.Size(138, 25);
            this.TXB_PacienteId.TabIndex = 3;
            // 
            // TXB_MedicoId
            // 
            this.TXB_MedicoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_MedicoId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_MedicoId.Location = new System.Drawing.Point(409, 350);
            this.TXB_MedicoId.Name = "TXB_MedicoId";
            this.TXB_MedicoId.Size = new System.Drawing.Size(138, 25);
            this.TXB_MedicoId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(331, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(336, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(309, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "PacienteId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(318, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "MedicoId";
            // 
            // BTN_CargarTurno
            // 
            this.BTN_CargarTurno.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_CargarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CargarTurno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CargarTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_CargarTurno.Location = new System.Drawing.Point(428, 395);
            this.BTN_CargarTurno.Name = "BTN_CargarTurno";
            this.BTN_CargarTurno.Size = new System.Drawing.Size(119, 27);
            this.BTN_CargarTurno.TabIndex = 10;
            this.BTN_CargarTurno.Text = "Cargar Turno";
            this.BTN_CargarTurno.UseVisualStyleBackColor = false;
            this.BTN_CargarTurno.Click += new System.EventHandler(this.BTN_CargarTurno_Click);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_Volver.LinkColor = System.Drawing.SystemColors.Control;
            this.LL_Volver.Location = new System.Drawing.Point(470, 441);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(47, 17);
            this.LL_Volver.TabIndex = 11;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // BTN_AgregarPaciente
            // 
            this.BTN_AgregarPaciente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_AgregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AgregarPaciente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AgregarPaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_AgregarPaciente.Location = new System.Drawing.Point(553, 314);
            this.BTN_AgregarPaciente.Name = "BTN_AgregarPaciente";
            this.BTN_AgregarPaciente.Size = new System.Drawing.Size(22, 25);
            this.BTN_AgregarPaciente.TabIndex = 12;
            this.BTN_AgregarPaciente.Text = "+";
            this.BTN_AgregarPaciente.UseVisualStyleBackColor = false;
            this.BTN_AgregarPaciente.Click += new System.EventHandler(this.BTN_AgregarPaciente_Click);
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Fecha.Location = new System.Drawing.Point(409, 249);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(200, 20);
            this.DTP_Fecha.TabIndex = 13;
            // 
            // BTN_VerPacientes
            // 
            this.BTN_VerPacientes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_VerPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VerPacientes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VerPacientes.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_VerPacientes.Location = new System.Drawing.Point(581, 314);
            this.BTN_VerPacientes.Name = "BTN_VerPacientes";
            this.BTN_VerPacientes.Size = new System.Drawing.Size(76, 25);
            this.BTN_VerPacientes.TabIndex = 14;
            this.BTN_VerPacientes.Text = "Ver pacientes";
            this.BTN_VerPacientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_VerPacientes.UseVisualStyleBackColor = false;
            this.BTN_VerPacientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_VerMedicos
            // 
            this.BTN_VerMedicos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_VerMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VerMedicos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VerMedicos.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_VerMedicos.Location = new System.Drawing.Point(553, 350);
            this.BTN_VerMedicos.Name = "BTN_VerMedicos";
            this.BTN_VerMedicos.Size = new System.Drawing.Size(82, 25);
            this.BTN_VerMedicos.TabIndex = 15;
            this.BTN_VerMedicos.Text = "Ver medicos";
            this.BTN_VerMedicos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_VerMedicos.UseVisualStyleBackColor = false;
            this.BTN_VerMedicos.Click += new System.EventHandler(this.BTN_VerMedicos_Click);
            // 
            // AsignarTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.BTN_VerMedicos);
            this.Controls.Add(this.BTN_VerPacientes);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.BTN_AgregarPaciente);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_CargarTurno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_MedicoId);
            this.Controls.Add(this.TXB_PacienteId);
            this.Controls.Add(this.TXB_Hora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsignarTurnoForm";
            this.Text = "AsignarTurnoForm";
            this.Load += new System.EventHandler(this.AsignarTurnoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXB_Hora;
        private System.Windows.Forms.TextBox TXB_PacienteId;
        private System.Windows.Forms.TextBox TXB_MedicoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_CargarTurno;
        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.Button BTN_AgregarPaciente;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
        private System.Windows.Forms.Button BTN_VerPacientes;
        private System.Windows.Forms.Button BTN_VerMedicos;
    }
}