namespace CapaPresentacion.Forms
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.LL_login = new System.Windows.Forms.LinkLabel();
            this.BTN_register = new System.Windows.Forms.Button();
            this.CHB_medic = new System.Windows.Forms.CheckBox();
            this.CHB_secretario = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXB_legajo = new System.Windows.Forms.TextBox();
            this.PN_secretary = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_horariosalida = new System.Windows.Forms.TextBox();
            this.TXB_horarioentrada = new System.Windows.Forms.TextBox();
            this.TXB_email = new System.Windows.Forms.TextBox();
            this.PN_medic = new System.Windows.Forms.Panel();
            this.CMB_Especialidades = new System.Windows.Forms.ComboBox();
            this.BTN_AgregarEspecialidad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_matricula = new System.Windows.Forms.TextBox();
            this.TXB_phone = new System.Windows.Forms.TextBox();
            this.TXB_dni = new System.Windows.Forms.TextBox();
            this.TXB_name = new System.Windows.Forms.TextBox();
            this.TXB_surname = new System.Windows.Forms.TextBox();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.PN_secretary.SuspendLayout();
            this.PN_medic.SuspendLayout();
            this.SuspendLayout();
            // 
            // LL_login
            // 
            this.LL_login.AutoSize = true;
            this.LL_login.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_login.LinkColor = System.Drawing.SystemColors.Control;
            this.LL_login.Location = new System.Drawing.Point(464, 629);
            this.LL_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LL_login.Name = "LL_login";
            this.LL_login.Size = new System.Drawing.Size(61, 17);
            this.LL_login.TabIndex = 29;
            this.LL_login.TabStop = true;
            this.LL_login.Text = "Ingresar";
            this.LL_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_login_LinkClicked);
            // 
            // BTN_register
            // 
            this.BTN_register.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_register.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_register.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_register.Location = new System.Drawing.Point(423, 579);
            this.BTN_register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_register.Name = "BTN_register";
            this.BTN_register.Size = new System.Drawing.Size(138, 45);
            this.BTN_register.TabIndex = 43;
            this.BTN_register.Text = "Registrarse";
            this.BTN_register.UseVisualStyleBackColor = false;
            this.BTN_register.Click += new System.EventHandler(this.BTN_register_Click);
            // 
            // CHB_medic
            // 
            this.CHB_medic.AutoSize = true;
            this.CHB_medic.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_medic.ForeColor = System.Drawing.SystemColors.Control;
            this.CHB_medic.Location = new System.Drawing.Point(525, 551);
            this.CHB_medic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CHB_medic.Name = "CHB_medic";
            this.CHB_medic.Size = new System.Drawing.Size(73, 21);
            this.CHB_medic.TabIndex = 42;
            this.CHB_medic.Text = "Medico";
            this.CHB_medic.UseVisualStyleBackColor = true;
            this.CHB_medic.CheckedChanged += new System.EventHandler(this.CHB_medic_CheckedChanged);
            // 
            // CHB_secretario
            // 
            this.CHB_secretario.AutoSize = true;
            this.CHB_secretario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_secretario.ForeColor = System.Drawing.SystemColors.Control;
            this.CHB_secretario.Location = new System.Drawing.Point(408, 551);
            this.CHB_secretario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CHB_secretario.Name = "CHB_secretario";
            this.CHB_secretario.Size = new System.Drawing.Size(94, 21);
            this.CHB_secretario.TabIndex = 41;
            this.CHB_secretario.Text = "Secretario";
            this.CHB_secretario.UseVisualStyleBackColor = true;
            this.CHB_secretario.CheckedChanged += new System.EventHandler(this.CHB_secretario_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 26F);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(380, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 35);
            this.label13.TabIndex = 40;
            this.label13.Text = "Registrate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(379, 387);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 39;
            this.label12.Text = "Legajo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(370, 337);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(383, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(361, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 30);
            this.label9.TabIndex = 36;
            this.label9.Text = "Fecha de \r\nnacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(370, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(379, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(392, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "DNI";
            // 
            // TXB_legajo
            // 
            this.TXB_legajo.BackColor = System.Drawing.SystemColors.Window;
            this.TXB_legajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_legajo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_legajo.Location = new System.Drawing.Point(472, 382);
            this.TXB_legajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_legajo.Name = "TXB_legajo";
            this.TXB_legajo.Size = new System.Drawing.Size(126, 25);
            this.TXB_legajo.TabIndex = 32;
            // 
            // PN_secretary
            // 
            this.PN_secretary.Controls.Add(this.label2);
            this.PN_secretary.Controls.Add(this.label1);
            this.PN_secretary.Controls.Add(this.TXB_horariosalida);
            this.PN_secretary.Controls.Add(this.TXB_horarioentrada);
            this.PN_secretary.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.PN_secretary.ForeColor = System.Drawing.SystemColors.Control;
            this.PN_secretary.Location = new System.Drawing.Point(279, 426);
            this.PN_secretary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PN_secretary.Name = "PN_secretary";
            this.PN_secretary.Size = new System.Drawing.Size(370, 115);
            this.PN_secretary.TabIndex = 25;
            this.PN_secretary.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Horario salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Horario entrada";
            // 
            // TXB_horariosalida
            // 
            this.TXB_horariosalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_horariosalida.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_horariosalida.Location = new System.Drawing.Point(193, 69);
            this.TXB_horariosalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_horariosalida.Name = "TXB_horariosalida";
            this.TXB_horariosalida.Size = new System.Drawing.Size(126, 25);
            this.TXB_horariosalida.TabIndex = 12;
            // 
            // TXB_horarioentrada
            // 
            this.TXB_horarioentrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_horarioentrada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_horarioentrada.Location = new System.Drawing.Point(193, 13);
            this.TXB_horarioentrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_horarioentrada.Name = "TXB_horarioentrada";
            this.TXB_horarioentrada.Size = new System.Drawing.Size(126, 25);
            this.TXB_horarioentrada.TabIndex = 13;
            // 
            // TXB_email
            // 
            this.TXB_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_email.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_email.Location = new System.Drawing.Point(472, 282);
            this.TXB_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_email.Name = "TXB_email";
            this.TXB_email.Size = new System.Drawing.Size(126, 25);
            this.TXB_email.TabIndex = 31;
            // 
            // PN_medic
            // 
            this.PN_medic.Controls.Add(this.CMB_Especialidades);
            this.PN_medic.Controls.Add(this.BTN_AgregarEspecialidad);
            this.PN_medic.Controls.Add(this.label4);
            this.PN_medic.Controls.Add(this.label3);
            this.PN_medic.Controls.Add(this.TXB_matricula);
            this.PN_medic.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.PN_medic.ForeColor = System.Drawing.SystemColors.Control;
            this.PN_medic.Location = new System.Drawing.Point(302, 434);
            this.PN_medic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PN_medic.Name = "PN_medic";
            this.PN_medic.Size = new System.Drawing.Size(317, 91);
            this.PN_medic.TabIndex = 24;
            this.PN_medic.Visible = false;
            // 
            // CMB_Especialidades
            // 
            this.CMB_Especialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Especialidades.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Especialidades.FormattingEnabled = true;
            this.CMB_Especialidades.Location = new System.Drawing.Point(170, 47);
            this.CMB_Especialidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMB_Especialidades.Name = "CMB_Especialidades";
            this.CMB_Especialidades.Size = new System.Drawing.Size(116, 25);
            this.CMB_Especialidades.TabIndex = 5;
            // 
            // BTN_AgregarEspecialidad
            // 
            this.BTN_AgregarEspecialidad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_AgregarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AgregarEspecialidad.Location = new System.Drawing.Point(290, 47);
            this.BTN_AgregarEspecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_AgregarEspecialidad.Name = "BTN_AgregarEspecialidad";
            this.BTN_AgregarEspecialidad.Size = new System.Drawing.Size(23, 25);
            this.BTN_AgregarEspecialidad.TabIndex = 4;
            this.BTN_AgregarEspecialidad.Text = "+";
            this.BTN_AgregarEspecialidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_AgregarEspecialidad.UseVisualStyleBackColor = false;
            this.BTN_AgregarEspecialidad.Click += new System.EventHandler(this.BTN_AgregarEspecialidad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especialidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXB_matricula
            // 
            this.TXB_matricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_matricula.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_matricula.Location = new System.Drawing.Point(170, 7);
            this.TXB_matricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_matricula.Name = "TXB_matricula";
            this.TXB_matricula.Size = new System.Drawing.Size(116, 25);
            this.TXB_matricula.TabIndex = 0;
            // 
            // TXB_phone
            // 
            this.TXB_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_phone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_phone.Location = new System.Drawing.Point(472, 332);
            this.TXB_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_phone.Name = "TXB_phone";
            this.TXB_phone.Size = new System.Drawing.Size(126, 25);
            this.TXB_phone.TabIndex = 30;
            // 
            // TXB_dni
            // 
            this.TXB_dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_dni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_dni.Location = new System.Drawing.Point(472, 82);
            this.TXB_dni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_dni.Name = "TXB_dni";
            this.TXB_dni.Size = new System.Drawing.Size(126, 25);
            this.TXB_dni.TabIndex = 23;
            this.TXB_dni.TextChanged += new System.EventHandler(this.TXB_dni_TextChanged);
            // 
            // TXB_name
            // 
            this.TXB_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_name.Location = new System.Drawing.Point(472, 131);
            this.TXB_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_name.Name = "TXB_name";
            this.TXB_name.Size = new System.Drawing.Size(126, 25);
            this.TXB_name.TabIndex = 27;
            // 
            // TXB_surname
            // 
            this.TXB_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_surname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_surname.Location = new System.Drawing.Point(472, 182);
            this.TXB_surname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_surname.Name = "TXB_surname";
            this.TXB_surname.Size = new System.Drawing.Size(126, 25);
            this.TXB_surname.TabIndex = 26;
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Fecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Fecha.Location = new System.Drawing.Point(472, 232);
            this.DTP_Fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(233, 22);
            this.DTP_Fecha.TabIndex = 6;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.PN_medic);
            this.Controls.Add(this.LL_login);
            this.Controls.Add(this.BTN_register);
            this.Controls.Add(this.CHB_medic);
            this.Controls.Add(this.CHB_secretario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXB_legajo);
            this.Controls.Add(this.TXB_email);
            this.Controls.Add(this.TXB_phone);
            this.Controls.Add(this.TXB_dni);
            this.Controls.Add(this.TXB_name);
            this.Controls.Add(this.TXB_surname);
            this.Controls.Add(this.PN_secretary);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.PN_secretary.ResumeLayout(false);
            this.PN_secretary.PerformLayout();
            this.PN_medic.ResumeLayout(false);
            this.PN_medic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LL_login;
        private System.Windows.Forms.Button BTN_register;
        private System.Windows.Forms.CheckBox CHB_medic;
        private System.Windows.Forms.CheckBox CHB_secretario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXB_legajo;
        private System.Windows.Forms.Panel PN_secretary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_horariosalida;
        private System.Windows.Forms.TextBox TXB_horarioentrada;
        private System.Windows.Forms.TextBox TXB_email;
        private System.Windows.Forms.Panel PN_medic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_matricula;
        private System.Windows.Forms.TextBox TXB_phone;
        private System.Windows.Forms.TextBox TXB_dni;
        private System.Windows.Forms.TextBox TXB_name;
        private System.Windows.Forms.TextBox TXB_surname;
        private System.Windows.Forms.Button BTN_AgregarEspecialidad;
        private System.Windows.Forms.ComboBox CMB_Especialidades;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
    }
}