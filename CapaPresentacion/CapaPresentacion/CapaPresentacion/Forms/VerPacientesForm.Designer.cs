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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPacientesForm));
            this.DGV_Pacientes = new System.Windows.Forms.DataGridView();
            this.TXB_DNI = new System.Windows.Forms.TextBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Pacientes
            // 
            this.DGV_Pacientes.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.DGV_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pacientes.Location = new System.Drawing.Point(0, 0);
            this.DGV_Pacientes.Name = "DGV_Pacientes";
            this.DGV_Pacientes.Size = new System.Drawing.Size(789, 665);
            this.DGV_Pacientes.TabIndex = 0;
            this.DGV_Pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Pacientes_CellContentClick);
            // 
            // TXB_DNI
            // 
            this.TXB_DNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_DNI.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_DNI.Location = new System.Drawing.Point(813, 312);
            this.TXB_DNI.Name = "TXB_DNI";
            this.TXB_DNI.Size = new System.Drawing.Size(139, 25);
            this.TXB_DNI.TabIndex = 1;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Buscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Buscar.Location = new System.Drawing.Point(813, 342);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(139, 27);
            this.BTN_Buscar.TabIndex = 2;
            this.BTN_Buscar.Text = "Buscar por ID";
            this.BTN_Buscar.UseVisualStyleBackColor = false;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_Volver.LinkColor = System.Drawing.SystemColors.Control;
            this.LL_Volver.Location = new System.Drawing.Point(921, 634);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(51, 18);
            this.LL_Volver.TabIndex = 62;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(811, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Id del paciente";
            // 
            // VerPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.TXB_DNI);
            this.Controls.Add(this.DGV_Pacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
    }
}