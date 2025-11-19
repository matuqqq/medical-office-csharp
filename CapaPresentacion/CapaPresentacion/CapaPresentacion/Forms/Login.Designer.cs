namespace CapaPresentacion.Forms
{
    partial class Login
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
            this.LL_register = new System.Windows.Forms.LinkLabel();
            this.BTN_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXB_name = new System.Windows.Forms.TextBox();
            this.TXB_surname = new System.Windows.Forms.TextBox();
            this.TXB_dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LL_register
            // 
            this.LL_register.AutoSize = true;
            this.LL_register.Location = new System.Drawing.Point(307, 323);
            this.LL_register.Name = "LL_register";
            this.LL_register.Size = new System.Drawing.Size(60, 13);
            this.LL_register.TabIndex = 17;
            this.LL_register.TabStop = true;
            this.LL_register.Text = "Registrarse";
            this.LL_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_register_LinkClicked);
            // 
            // BTN_login
            // 
            this.BTN_login.Location = new System.Drawing.Point(300, 287);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(75, 23);
            this.BTN_login.TabIndex = 16;
            this.BTN_login.Text = "Ingresar";
            this.BTN_login.UseVisualStyleBackColor = true;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "DNI";
            // 
            // TXB_name
            // 
            this.TXB_name.Location = new System.Drawing.Point(267, 221);
            this.TXB_name.Name = "TXB_name";
            this.TXB_name.Size = new System.Drawing.Size(140, 20);
            this.TXB_name.TabIndex = 12;
            // 
            // TXB_surname
            // 
            this.TXB_surname.Location = new System.Drawing.Point(267, 159);
            this.TXB_surname.Name = "TXB_surname";
            this.TXB_surname.Size = new System.Drawing.Size(140, 20);
            this.TXB_surname.TabIndex = 11;
            // 
            // TXB_dni
            // 
            this.TXB_dni.Location = new System.Drawing.Point(267, 100);
            this.TXB_dni.Name = "TXB_dni";
            this.TXB_dni.Size = new System.Drawing.Size(140, 20);
            this.TXB_dni.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "¡BIENVENIDO!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LL_register);
            this.Controls.Add(this.BTN_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXB_name);
            this.Controls.Add(this.TXB_surname);
            this.Controls.Add(this.TXB_dni);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LL_register;
        private System.Windows.Forms.Button BTN_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXB_name;
        private System.Windows.Forms.TextBox TXB_surname;
        private System.Windows.Forms.TextBox TXB_dni;
        private System.Windows.Forms.Label label1;
    }
}