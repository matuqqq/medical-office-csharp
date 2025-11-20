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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
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
            this.LL_register.Font = new System.Drawing.Font("Arial", 10F);
            this.LL_register.LinkColor = System.Drawing.Color.White;
            this.LL_register.Location = new System.Drawing.Point(452, 454);
            this.LL_register.Name = "LL_register";
            this.LL_register.Size = new System.Drawing.Size(80, 16);
            this.LL_register.TabIndex = 17;
            this.LL_register.TabStop = true;
            this.LL_register.Text = "Registrarse";
            this.LL_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_register_LinkClicked);
            // 
            // BTN_login
            // 
            this.BTN_login.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_login.FlatAppearance.BorderSize = 0;
            this.BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_login.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_login.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_login.Location = new System.Drawing.Point(439, 411);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(107, 26);
            this.BTN_login.TabIndex = 16;
            this.BTN_login.Text = "Ingresar";
            this.BTN_login.UseVisualStyleBackColor = false;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(462, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(453, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(475, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "DNI";
            // 
            // TXB_name
            // 
            this.TXB_name.BackColor = System.Drawing.SystemColors.Window;
            this.TXB_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TXB_name.Location = new System.Drawing.Point(422, 318);
            this.TXB_name.Name = "TXB_name";
            this.TXB_name.Size = new System.Drawing.Size(140, 25);
            this.TXB_name.TabIndex = 12;
            // 
            // TXB_surname
            // 
            this.TXB_surname.BackColor = System.Drawing.SystemColors.Window;
            this.TXB_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_surname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_surname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TXB_surname.Location = new System.Drawing.Point(422, 256);
            this.TXB_surname.Name = "TXB_surname";
            this.TXB_surname.Size = new System.Drawing.Size(140, 25);
            this.TXB_surname.TabIndex = 11;
            // 
            // TXB_dni
            // 
            this.TXB_dni.BackColor = System.Drawing.SystemColors.Window;
            this.TXB_dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_dni.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TXB_dni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_dni.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TXB_dni.Location = new System.Drawing.Point(422, 197);
            this.TXB_dni.Name = "TXB_dni";
            this.TXB_dni.Size = new System.Drawing.Size(140, 25);
            this.TXB_dni.TabIndex = 10;
            this.TXB_dni.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(375, 124);
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
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.LL_register);
            this.Controls.Add(this.BTN_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXB_name);
            this.Controls.Add(this.TXB_surname);
            this.Controls.Add(this.TXB_dni);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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