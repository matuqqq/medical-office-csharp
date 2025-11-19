namespace CapaPresentacion.Forms
{
    partial class TurnoForm
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
            this.components = new System.ComponentModel.Container();
            this.DGV_Turnos = new System.Windows.Forms.DataGridView();
            this.consultorioV1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_HistorialClinico = new System.Windows.Forms.Button();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Turnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioV1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Turnos
            // 
            this.DGV_Turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Turnos.Location = new System.Drawing.Point(0, 0);
            this.DGV_Turnos.Name = "DGV_Turnos";
            this.DGV_Turnos.Size = new System.Drawing.Size(628, 452);
            this.DGV_Turnos.TabIndex = 0;
            // 
            // BTN_HistorialClinico
            // 
            this.BTN_HistorialClinico.Location = new System.Drawing.Point(676, 183);
            this.BTN_HistorialClinico.Name = "BTN_HistorialClinico";
            this.BTN_HistorialClinico.Size = new System.Drawing.Size(85, 85);
            this.BTN_HistorialClinico.TabIndex = 1;
            this.BTN_HistorialClinico.Text = "Ver Historial Clinico";
            this.BTN_HistorialClinico.UseVisualStyleBackColor = true;
            this.BTN_HistorialClinico.Click += new System.EventHandler(this.BTN_HistorialClinico_Click);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Location = new System.Drawing.Point(751, 428);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(37, 13);
            this.LL_Volver.TabIndex = 12;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // TurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_HistorialClinico);
            this.Controls.Add(this.DGV_Turnos);
            this.Name = "TurnoForm";
            this.Text = "TurnoForm";
            this.Load += new System.EventHandler(this.TurnoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Turnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioV1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Turnos;
        private System.Windows.Forms.BindingSource consultorioDataSetBindingSource;
        private System.Windows.Forms.Button BTN_HistorialClinico;
        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.BindingSource consultorioV1DataSetBindingSource;
    }
}