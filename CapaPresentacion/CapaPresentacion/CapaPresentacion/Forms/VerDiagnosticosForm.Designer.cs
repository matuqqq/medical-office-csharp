namespace CapaPresentacion.Forms
{
    partial class VerDiagnosticosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerDiagnosticosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_PacienteId = new System.Windows.Forms.TextBox();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.DGV_Diagnosticos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Diagnosticos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id del paciente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXB_PacienteId
            // 
            this.TXB_PacienteId.BackColor = System.Drawing.SystemColors.Window;
            this.TXB_PacienteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_PacienteId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_PacienteId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TXB_PacienteId.Location = new System.Drawing.Point(15, 311);
            this.TXB_PacienteId.Name = "TXB_PacienteId";
            this.TXB_PacienteId.Size = new System.Drawing.Size(139, 25);
            this.TXB_PacienteId.TabIndex = 9;
            this.TXB_PacienteId.TextChanged += new System.EventHandler(this.TXB_PacienteId_TextChanged);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_Volver.LinkColor = System.Drawing.SystemColors.Control;
            this.LL_Volver.Location = new System.Drawing.Point(12, 632);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(47, 17);
            this.LL_Volver.TabIndex = 8;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked_1);
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Buscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Buscar.Location = new System.Drawing.Point(15, 351);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(140, 29);
            this.BTN_Buscar.TabIndex = 7;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = false;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click_1);
            // 
            // DGV_Diagnosticos
            // 
            this.DGV_Diagnosticos.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.DGV_Diagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Diagnosticos.Location = new System.Drawing.Point(161, 3);
            this.DGV_Diagnosticos.Name = "DGV_Diagnosticos";
            this.DGV_Diagnosticos.Size = new System.Drawing.Size(823, 659);
            this.DGV_Diagnosticos.TabIndex = 6;
            // 
            // VerDiagnosticosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_PacienteId);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.DGV_Diagnosticos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerDiagnosticosForm";
            this.Text = "VerDiagnosticosForm";
            this.Load += new System.EventHandler(this.VerDiagnosticosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Diagnosticos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_PacienteId;
        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.DataGridView DGV_Diagnosticos;
    }
}