namespace CapaPresentacion.Forms
{
    partial class VerMedicosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerMedicosForm));
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.TXB_DNI = new System.Windows.Forms.TextBox();
            this.DGV_Medicos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Medicos)).BeginInit();
            this.SuspendLayout();
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_Volver.LinkColor = System.Drawing.SystemColors.Control;
            this.LL_Volver.Location = new System.Drawing.Point(925, 635);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(47, 17);
            this.LL_Volver.TabIndex = 66;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Buscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Buscar.Location = new System.Drawing.Point(821, 343);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(121, 34);
            this.BTN_Buscar.TabIndex = 65;
            this.BTN_Buscar.Text = "Buscar por ID";
            this.BTN_Buscar.UseVisualStyleBackColor = false;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // TXB_DNI
            // 
            this.TXB_DNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_DNI.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_DNI.Location = new System.Drawing.Point(821, 308);
            this.TXB_DNI.Name = "TXB_DNI";
            this.TXB_DNI.Size = new System.Drawing.Size(121, 25);
            this.TXB_DNI.TabIndex = 64;
            this.TXB_DNI.TextChanged += new System.EventHandler(this.TXB_DNI_TextChanged);
            // 
            // DGV_Medicos
            // 
            this.DGV_Medicos.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.DGV_Medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Medicos.Location = new System.Drawing.Point(-1, 0);
            this.DGV_Medicos.Name = "DGV_Medicos";
            this.DGV_Medicos.Size = new System.Drawing.Size(792, 661);
            this.DGV_Medicos.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(818, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 67;
            this.label1.Text = "Id del medico";
            // 
            // VerMedicosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.TXB_DNI);
            this.Controls.Add(this.DGV_Medicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerMedicosForm";
            this.Text = "VerMedicosForm";
            this.Load += new System.EventHandler(this.VerMedicosForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Medicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.TextBox TXB_DNI;
        private System.Windows.Forms.DataGridView DGV_Medicos;
        private System.Windows.Forms.Label label1;
    }
}