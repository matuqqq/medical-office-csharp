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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialClinicoForm));
            this.DGV_HistorialClinico = new System.Windows.Forms.DataGridView();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.TXB_PacienteId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_VerDiagnosticos = new System.Windows.Forms.Button();
            this.PN_Medico = new System.Windows.Forms.Panel();
            this.BTN_VolverMenu = new System.Windows.Forms.Button();
            this.PN_Secretario = new System.Windows.Forms.Panel();
            this.BTN_VolverSecretario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HistorialClinico)).BeginInit();
            this.PN_Medico.SuspendLayout();
            this.PN_Secretario.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_HistorialClinico
            // 
            this.DGV_HistorialClinico.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.DGV_HistorialClinico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_HistorialClinico.Location = new System.Drawing.Point(135, 0);
            this.DGV_HistorialClinico.Name = "DGV_HistorialClinico";
            this.DGV_HistorialClinico.Size = new System.Drawing.Size(857, 669);
            this.DGV_HistorialClinico.TabIndex = 0;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Buscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Buscar.Location = new System.Drawing.Point(12, 333);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(105, 37);
            this.BTN_Buscar.TabIndex = 1;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = false;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_Volver.LinkColor = System.Drawing.SystemColors.Control;
            this.LL_Volver.Location = new System.Drawing.Point(41, 639);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(47, 17);
            this.LL_Volver.TabIndex = 2;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // TXB_PacienteId
            // 
            this.TXB_PacienteId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_PacienteId.Location = new System.Drawing.Point(12, 291);
            this.TXB_PacienteId.Name = "TXB_PacienteId";
            this.TXB_PacienteId.Size = new System.Drawing.Size(105, 25);
            this.TXB_PacienteId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id del paciente";
            // 
            // BTN_VerDiagnosticos
            // 
            this.BTN_VerDiagnosticos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_VerDiagnosticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VerDiagnosticos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VerDiagnosticos.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_VerDiagnosticos.Location = new System.Drawing.Point(12, 376);
            this.BTN_VerDiagnosticos.Name = "BTN_VerDiagnosticos";
            this.BTN_VerDiagnosticos.Size = new System.Drawing.Size(105, 55);
            this.BTN_VerDiagnosticos.TabIndex = 5;
            this.BTN_VerDiagnosticos.Text = "Ver Diagnosticos";
            this.BTN_VerDiagnosticos.UseVisualStyleBackColor = false;
            this.BTN_VerDiagnosticos.Click += new System.EventHandler(this.BTN_VerDiagnosticos_Click);
            // 
            // PN_Medico
            // 
            this.PN_Medico.Controls.Add(this.BTN_VolverMenu);
            this.PN_Medico.Location = new System.Drawing.Point(0, 0);
            this.PN_Medico.Name = "PN_Medico";
            this.PN_Medico.Size = new System.Drawing.Size(131, 84);
            this.PN_Medico.TabIndex = 6;
            this.PN_Medico.Visible = false;
            // 
            // BTN_VolverMenu
            // 
            this.BTN_VolverMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_VolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VolverMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VolverMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_VolverMenu.Location = new System.Drawing.Point(7, 12);
            this.BTN_VolverMenu.Name = "BTN_VolverMenu";
            this.BTN_VolverMenu.Size = new System.Drawing.Size(121, 58);
            this.BTN_VolverMenu.TabIndex = 0;
            this.BTN_VolverMenu.Text = "Volver a menu principal";
            this.BTN_VolverMenu.UseVisualStyleBackColor = false;
            this.BTN_VolverMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // PN_Secretario
            // 
            this.PN_Secretario.Controls.Add(this.BTN_VolverSecretario);
            this.PN_Secretario.Location = new System.Drawing.Point(0, 0);
            this.PN_Secretario.Name = "PN_Secretario";
            this.PN_Secretario.Size = new System.Drawing.Size(131, 84);
            this.PN_Secretario.TabIndex = 7;
            this.PN_Secretario.Visible = false;
            // 
            // BTN_VolverSecretario
            // 
            this.BTN_VolverSecretario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_VolverSecretario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VolverSecretario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VolverSecretario.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_VolverSecretario.Location = new System.Drawing.Point(7, 12);
            this.BTN_VolverSecretario.Name = "BTN_VolverSecretario";
            this.BTN_VolverSecretario.Size = new System.Drawing.Size(121, 58);
            this.BTN_VolverSecretario.TabIndex = 0;
            this.BTN_VolverSecretario.Text = "Volver a menu principal";
            this.BTN_VolverSecretario.UseVisualStyleBackColor = false;
            this.BTN_VolverSecretario.Click += new System.EventHandler(this.BTN_VolverSecretario_Click);
            // 
            // HistorialClinicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.PN_Medico);
            this.Controls.Add(this.BTN_VerDiagnosticos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_PacienteId);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.DGV_HistorialClinico);
            this.Controls.Add(this.PN_Secretario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialClinicoForm";
            this.Text = "HistorialClinicoForm";
            this.Load += new System.EventHandler(this.HistorialClinicoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HistorialClinico)).EndInit();
            this.PN_Medico.ResumeLayout(false);
            this.PN_Secretario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_HistorialClinico;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.LinkLabel LL_Volver;
        private System.Windows.Forms.TextBox TXB_PacienteId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_VerDiagnosticos;
        private System.Windows.Forms.Panel PN_Medico;
        private System.Windows.Forms.Button BTN_VolverMenu;
        private System.Windows.Forms.Panel PN_Secretario;
        private System.Windows.Forms.Button BTN_VolverSecretario;
    }
}