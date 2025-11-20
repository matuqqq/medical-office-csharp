namespace CapaPresentacion.Forms
{
    partial class EspecialidadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspecialidadForm));
            this.TXB_EspecialidadNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.BTN_Cargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXB_EspecialidadNom
            // 
            this.TXB_EspecialidadNom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_EspecialidadNom.Location = new System.Drawing.Point(491, 297);
            this.TXB_EspecialidadNom.Name = "TXB_EspecialidadNom";
            this.TXB_EspecialidadNom.Size = new System.Drawing.Size(140, 25);
            this.TXB_EspecialidadNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(369, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la \r\nespecialidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_Volver.LinkColor = System.Drawing.SystemColors.Control;
            this.LL_Volver.Location = new System.Drawing.Point(472, 583);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(41, 16);
            this.LL_Volver.TabIndex = 2;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // BTN_Cargar
            // 
            this.BTN_Cargar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cargar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cargar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Cargar.Location = new System.Drawing.Point(455, 338);
            this.BTN_Cargar.Name = "BTN_Cargar";
            this.BTN_Cargar.Size = new System.Drawing.Size(75, 28);
            this.BTN_Cargar.TabIndex = 3;
            this.BTN_Cargar.Text = "Cargar";
            this.BTN_Cargar.UseVisualStyleBackColor = false;
            this.BTN_Cargar.Click += new System.EventHandler(this.BTN_Cargar_Click);
            // 
            // EspecialidadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.BTN_Cargar);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_EspecialidadNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EspecialidadForm";
            this.Text = "EspecialidadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_EspecialidadNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.Button BTN_Cargar;
    }
}