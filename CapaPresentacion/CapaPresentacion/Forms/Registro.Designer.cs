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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_especialidad = new System.Windows.Forms.TextBox();
            this.TXB_matricula = new System.Windows.Forms.TextBox();
            this.TXB_phone = new System.Windows.Forms.TextBox();
            this.TXB_dni = new System.Windows.Forms.TextBox();
            this.TXB_borndate = new System.Windows.Forms.TextBox();
            this.TXB_name = new System.Windows.Forms.TextBox();
            this.TXB_surname = new System.Windows.Forms.TextBox();
            this.PN_secretary.SuspendLayout();
            this.PN_medic.SuspendLayout();
            this.SuspendLayout();
            // 
            // LL_login
            // 
            this.LL_login.AutoSize = true;
            this.LL_login.Location = new System.Drawing.Point(394, 428);
            this.LL_login.Name = "LL_login";
            this.LL_login.Size = new System.Drawing.Size(45, 13);
            this.LL_login.TabIndex = 29;
            this.LL_login.TabStop = true;
            this.LL_login.Text = "Ingresar";
            this.LL_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_login_LinkClicked);
            // 
            // BTN_register
            // 
            this.BTN_register.Location = new System.Drawing.Point(385, 384);
            this.BTN_register.Name = "BTN_register";
            this.BTN_register.Size = new System.Drawing.Size(75, 23);
            this.BTN_register.TabIndex = 43;
            this.BTN_register.Text = "Registrarse";
            this.BTN_register.UseVisualStyleBackColor = true;
            this.BTN_register.Click += new System.EventHandler(this.BTN_register_Click);
            // 
            // CHB_medic
            // 
            this.CHB_medic.AutoSize = true;
            this.CHB_medic.Location = new System.Drawing.Point(431, 361);
            this.CHB_medic.Name = "CHB_medic";
            this.CHB_medic.Size = new System.Drawing.Size(61, 17);
            this.CHB_medic.TabIndex = 42;
            this.CHB_medic.Text = "Medico";
            this.CHB_medic.UseVisualStyleBackColor = true;
            this.CHB_medic.CheckedChanged += new System.EventHandler(this.CHB_medic_CheckedChanged);
            // 
            // CHB_secretario
            // 
            this.CHB_secretario.AutoSize = true;
            this.CHB_secretario.Location = new System.Drawing.Point(351, 361);
            this.CHB_secretario.Name = "CHB_secretario";
            this.CHB_secretario.Size = new System.Drawing.Size(74, 17);
            this.CHB_secretario.TabIndex = 41;
            this.CHB_secretario.Text = "Secretario";
            this.CHB_secretario.UseVisualStyleBackColor = true;
            this.CHB_secretario.CheckedChanged += new System.EventHandler(this.CHB_secretario_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(350, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 33);
            this.label13.TabIndex = 40;
            this.label13.Text = "Registrate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Legajo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 26);
            this.label9.TabIndex = 36;
            this.label9.Text = "Fecha de \r\nnacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "DNI";
            // 
            // TXB_legajo
            // 
            this.TXB_legajo.Location = new System.Drawing.Point(374, 254);
            this.TXB_legajo.Name = "TXB_legajo";
            this.TXB_legajo.Size = new System.Drawing.Size(100, 20);
            this.TXB_legajo.TabIndex = 32;
            // 
            // PN_secretary
            // 
            this.PN_secretary.Controls.Add(this.label2);
            this.PN_secretary.Controls.Add(this.label1);
            this.PN_secretary.Controls.Add(this.TXB_horariosalida);
            this.PN_secretary.Controls.Add(this.TXB_horarioentrada);
            this.PN_secretary.Location = new System.Drawing.Point(290, 280);
            this.PN_secretary.Name = "PN_secretary";
            this.PN_secretary.Size = new System.Drawing.Size(259, 75);
            this.PN_secretary.TabIndex = 25;
            this.PN_secretary.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Horario salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Horario entrada";
            // 
            // TXB_horariosalida
            // 
            this.TXB_horariosalida.Location = new System.Drawing.Point(85, 44);
            this.TXB_horariosalida.Name = "TXB_horariosalida";
            this.TXB_horariosalida.Size = new System.Drawing.Size(100, 20);
            this.TXB_horariosalida.TabIndex = 12;
            // 
            // TXB_horarioentrada
            // 
            this.TXB_horarioentrada.Location = new System.Drawing.Point(84, 9);
            this.TXB_horarioentrada.Name = "TXB_horarioentrada";
            this.TXB_horarioentrada.Size = new System.Drawing.Size(100, 20);
            this.TXB_horarioentrada.TabIndex = 13;
            // 
            // TXB_email
            // 
            this.TXB_email.Location = new System.Drawing.Point(374, 188);
            this.TXB_email.Name = "TXB_email";
            this.TXB_email.Size = new System.Drawing.Size(100, 20);
            this.TXB_email.TabIndex = 31;
            // 
            // PN_medic
            // 
            this.PN_medic.Controls.Add(this.label4);
            this.PN_medic.Controls.Add(this.label3);
            this.PN_medic.Controls.Add(this.TXB_especialidad);
            this.PN_medic.Controls.Add(this.TXB_matricula);
            this.PN_medic.Location = new System.Drawing.Point(251, 285);
            this.PN_medic.Name = "PN_medic";
            this.PN_medic.Size = new System.Drawing.Size(272, 59);
            this.PN_medic.TabIndex = 24;
            this.PN_medic.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especialidad";
            // 
            // TXB_especialidad
            // 
            this.TXB_especialidad.Location = new System.Drawing.Point(124, 34);
            this.TXB_especialidad.Name = "TXB_especialidad";
            this.TXB_especialidad.Size = new System.Drawing.Size(100, 20);
            this.TXB_especialidad.TabIndex = 1;
            // 
            // TXB_matricula
            // 
            this.TXB_matricula.Location = new System.Drawing.Point(123, 3);
            this.TXB_matricula.Name = "TXB_matricula";
            this.TXB_matricula.Size = new System.Drawing.Size(100, 20);
            this.TXB_matricula.TabIndex = 0;
            // 
            // TXB_phone
            // 
            this.TXB_phone.Location = new System.Drawing.Point(374, 221);
            this.TXB_phone.Name = "TXB_phone";
            this.TXB_phone.Size = new System.Drawing.Size(100, 20);
            this.TXB_phone.TabIndex = 30;
            // 
            // TXB_dni
            // 
            this.TXB_dni.Location = new System.Drawing.Point(374, 56);
            this.TXB_dni.Name = "TXB_dni";
            this.TXB_dni.Size = new System.Drawing.Size(100, 20);
            this.TXB_dni.TabIndex = 23;
            // 
            // TXB_borndate
            // 
            this.TXB_borndate.Location = new System.Drawing.Point(374, 155);
            this.TXB_borndate.Name = "TXB_borndate";
            this.TXB_borndate.Size = new System.Drawing.Size(100, 20);
            this.TXB_borndate.TabIndex = 28;
            // 
            // TXB_name
            // 
            this.TXB_name.Location = new System.Drawing.Point(374, 89);
            this.TXB_name.Name = "TXB_name";
            this.TXB_name.Size = new System.Drawing.Size(100, 20);
            this.TXB_name.TabIndex = 27;
            // 
            // TXB_surname
            // 
            this.TXB_surname.Location = new System.Drawing.Point(374, 122);
            this.TXB_surname.Name = "TXB_surname";
            this.TXB_surname.Size = new System.Drawing.Size(100, 20);
            this.TXB_surname.TabIndex = 26;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.PN_secretary);
            this.Controls.Add(this.TXB_email);
            this.Controls.Add(this.PN_medic);
            this.Controls.Add(this.TXB_phone);
            this.Controls.Add(this.TXB_dni);
            this.Controls.Add(this.TXB_borndate);
            this.Controls.Add(this.TXB_name);
            this.Controls.Add(this.TXB_surname);
            this.Name = "Registro";
            this.Text = "Registro";
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
        private System.Windows.Forms.TextBox TXB_especialidad;
        private System.Windows.Forms.TextBox TXB_matricula;
        private System.Windows.Forms.TextBox TXB_phone;
        private System.Windows.Forms.TextBox TXB_dni;
        private System.Windows.Forms.TextBox TXB_borndate;
        private System.Windows.Forms.TextBox TXB_name;
        private System.Windows.Forms.TextBox TXB_surname;
    }
}