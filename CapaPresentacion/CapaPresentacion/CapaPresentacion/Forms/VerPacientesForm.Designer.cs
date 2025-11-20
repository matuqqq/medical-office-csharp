namespace CapaPresentacion.Forms
{
    partial class VerPacientesForm
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
            this.DGV_Pacientes = new System.Windows.Forms.DataGridView();
            this.TXB_DNI = new System.Windows.Forms.TextBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Pacientes
            // 
            this.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pacientes.Location = new System.Drawing.Point(0, 0);
            this.DGV_Pacientes.Name = "DGV_Pacientes";
            this.DGV_Pacientes.Size = new System.Drawing.Size(640, 450);
            this.DGV_Pacientes.TabIndex = 0;
            this.DGV_Pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Pacientes_CellContentClick);
            // 
            // TXB_DNI
            // 
            this.TXB_DNI.Location = new System.Drawing.Point(670, 201);
            this.TXB_DNI.Name = "TXB_DNI";
            this.TXB_DNI.Size = new System.Drawing.Size(100, 20);
            this.TXB_DNI.TabIndex = 1;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(682, 227);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(75, 38);
            this.BTN_Buscar.TabIndex = 2;
            this.BTN_Buscar.Text = "Buscar por DNI";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Location = new System.Drawing.Point(706, 428);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(37, 13);
            this.LL_Volver.TabIndex = 62;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // VerPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.TXB_DNI);
            this.Controls.Add(this.DGV_Pacientes);
            this.Name = "VerPacientesForm";
            this.Text = "VerPacientesForm";
            this.Load += new System.EventHandler(this.VerPacientesForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Pacientes;
        private System.Windows.Forms.TextBox TXB_DNI;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.LinkLabel LL_Volver;
    }
}