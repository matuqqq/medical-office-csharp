namespace CapaPresentacion.Forms
{
    partial class HistorialClinicoForm
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
            this.DGV_HistorialClinico = new System.Windows.Forms.DataGridView();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.TXB_PacienteId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HistorialClinico)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_HistorialClinico
            // 
            this.DGV_HistorialClinico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_HistorialClinico.Location = new System.Drawing.Point(161, 3);
            this.DGV_HistorialClinico.Name = "DGV_HistorialClinico";
            this.DGV_HistorialClinico.Size = new System.Drawing.Size(627, 445);
            this.DGV_HistorialClinico.TabIndex = 0;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(24, 243);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Buscar.TabIndex = 1;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Location = new System.Drawing.Point(12, 428);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(37, 13);
            this.LL_Volver.TabIndex = 2;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // TXB_PacienteId
            // 
            this.TXB_PacienteId.Location = new System.Drawing.Point(24, 200);
            this.TXB_PacienteId.Name = "TXB_PacienteId";
            this.TXB_PacienteId.Size = new System.Drawing.Size(75, 20);
            this.TXB_PacienteId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id del paciente";
            // 
            // HistorialClinicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_PacienteId);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.DGV_HistorialClinico);
            this.Name = "HistorialClinicoForm";
            this.Text = "HistorialClinicoForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HistorialClinico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_HistorialClinico;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.TextBox TXB_PacienteId;
        private System.Windows.Forms.Label label1;
    }
}