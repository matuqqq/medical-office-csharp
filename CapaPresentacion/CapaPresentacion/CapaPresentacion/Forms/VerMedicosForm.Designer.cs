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
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.TXB_DNI = new System.Windows.Forms.TextBox();
            this.DGV_Medicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Medicos)).BeginInit();
            this.SuspendLayout();
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Location = new System.Drawing.Point(721, 428);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(37, 13);
            this.LL_Volver.TabIndex = 66;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(697, 227);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(75, 38);
            this.BTN_Buscar.TabIndex = 65;
            this.BTN_Buscar.Text = "Buscar por DNI";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // TXB_DNI
            // 
            this.TXB_DNI.Location = new System.Drawing.Point(685, 201);
            this.TXB_DNI.Name = "TXB_DNI";
            this.TXB_DNI.Size = new System.Drawing.Size(100, 20);
            this.TXB_DNI.TabIndex = 64;
            // 
            // DGV_Medicos
            // 
            this.DGV_Medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Medicos.Location = new System.Drawing.Point(15, 0);
            this.DGV_Medicos.Name = "DGV_Medicos";
            this.DGV_Medicos.Size = new System.Drawing.Size(640, 450);
            this.DGV_Medicos.TabIndex = 63;
            // 
            // VerMedicosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.TXB_DNI);
            this.Controls.Add(this.DGV_Medicos);
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
    }
}