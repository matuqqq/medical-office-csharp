
namespace CapaPresentacion.Forms
{
    partial class CargarPacienteForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXB_dni = new System.Windows.Forms.TextBox();
            this.TXB_name = new System.Windows.Forms.TextBox();
            this.TXB_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_ObraSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXB_NumeroAfiliado = new System.Windows.Forms.TextBox();
            this.BTN_Cargar = new System.Windows.Forms.Button();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(300, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 33);
            this.label13.TabIndex = 53;
            this.label13.Text = "Cargar Paciente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 26);
            this.label9.TabIndex = 52;
            this.label9.Text = "Fecha de \r\nnacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "DNI";
            // 
            // TXB_dni
            // 
            this.TXB_dni.Location = new System.Drawing.Point(370, 125);
            this.TXB_dni.Name = "TXB_dni";
            this.TXB_dni.Size = new System.Drawing.Size(100, 20);
            this.TXB_dni.TabIndex = 45;
            // 
            // TXB_name
            // 
            this.TXB_name.Location = new System.Drawing.Point(370, 156);
            this.TXB_name.Name = "TXB_name";
            this.TXB_name.Size = new System.Drawing.Size(100, 20);
            this.TXB_name.TabIndex = 47;
            // 
            // TXB_surname
            // 
            this.TXB_surname.Location = new System.Drawing.Point(370, 187);
            this.TXB_surname.Name = "TXB_surname";
            this.TXB_surname.Size = new System.Drawing.Size(100, 20);
            this.TXB_surname.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Obra Social";
            // 
            // TXB_ObraSocial
            // 
            this.TXB_ObraSocial.Location = new System.Drawing.Point(370, 249);
            this.TXB_ObraSocial.Name = "TXB_ObraSocial";
            this.TXB_ObraSocial.Size = new System.Drawing.Size(100, 20);
            this.TXB_ObraSocial.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Numero Afiliado";
            // 
            // TXB_NumeroAfiliado
            // 
            this.TXB_NumeroAfiliado.Location = new System.Drawing.Point(370, 280);
            this.TXB_NumeroAfiliado.Name = "TXB_NumeroAfiliado";
            this.TXB_NumeroAfiliado.Size = new System.Drawing.Size(100, 20);
            this.TXB_NumeroAfiliado.TabIndex = 56;
            // 
            // BTN_Cargar
            // 
            this.BTN_Cargar.Location = new System.Drawing.Point(370, 317);
            this.BTN_Cargar.Name = "BTN_Cargar";
            this.BTN_Cargar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cargar.TabIndex = 60;
            this.BTN_Cargar.Text = "Cargar";
            this.BTN_Cargar.UseVisualStyleBackColor = true;
            this.BTN_Cargar.Click += new System.EventHandler(this.BTN_Cargar_Click);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Location = new System.Drawing.Point(380, 428);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(37, 13);
            this.LL_Volver.TabIndex = 61;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Location = new System.Drawing.Point(370, 218);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(200, 20);
            this.DTP_Fecha.TabIndex = 62;
            // 
            // CargarPacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_Cargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXB_NumeroAfiliado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_ObraSocial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXB_dni);
            this.Controls.Add(this.TXB_name);
            this.Controls.Add(this.TXB_surname);
            this.Name = "CargarPacienteForm";
            this.Text = "CargarPacienteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXB_dni;
        private System.Windows.Forms.TextBox TXB_name;
        private System.Windows.Forms.TextBox TXB_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_ObraSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXB_NumeroAfiliado;
        private System.Windows.Forms.Button BTN_Cargar;
        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
    }
}