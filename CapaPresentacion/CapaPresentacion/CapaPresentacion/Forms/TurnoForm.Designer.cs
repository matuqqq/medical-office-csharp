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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnoForm));
            this.DGV_Turnos = new System.Windows.Forms.DataGridView();
            this.BTN_HistorialClinico = new System.Windows.Forms.Button();
            this.LL_Volver = new System.Windows.Forms.LinkLabel();
            this.PN_Secretario = new System.Windows.Forms.Panel();
            this.BTN_Actualizar = new System.Windows.Forms.Button();
            this.BTN_BorrarTurno = new System.Windows.Forms.Button();
            this.CMB_Turnos = new System.Windows.Forms.ComboBox();
            this.consultorioV1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Turnos)).BeginInit();
            this.PN_Secretario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioV1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Turnos
            // 
            this.DGV_Turnos.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.DGV_Turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Turnos.Location = new System.Drawing.Point(0, 0);
            this.DGV_Turnos.Name = "DGV_Turnos";
            this.DGV_Turnos.Size = new System.Drawing.Size(700, 665);
            this.DGV_Turnos.TabIndex = 0;
            // 
            // BTN_HistorialClinico
            // 
            this.BTN_HistorialClinico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_HistorialClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HistorialClinico.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_HistorialClinico.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_HistorialClinico.Location = new System.Drawing.Point(795, 211);
            this.BTN_HistorialClinico.Name = "BTN_HistorialClinico";
            this.BTN_HistorialClinico.Size = new System.Drawing.Size(97, 87);
            this.BTN_HistorialClinico.TabIndex = 1;
            this.BTN_HistorialClinico.Text = "Ver Historial Clinico";
            this.BTN_HistorialClinico.UseVisualStyleBackColor = false;
            this.BTN_HistorialClinico.Click += new System.EventHandler(this.BTN_HistorialClinico_Click);
            // 
            // LL_Volver
            // 
            this.LL_Volver.AutoSize = true;
            this.LL_Volver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_Volver.ForeColor = System.Drawing.SystemColors.Control;
            this.LL_Volver.LinkColor = System.Drawing.SystemColors.Control;
            this.LL_Volver.Location = new System.Drawing.Point(921, 634);
            this.LL_Volver.Name = "LL_Volver";
            this.LL_Volver.Size = new System.Drawing.Size(51, 18);
            this.LL_Volver.TabIndex = 12;
            this.LL_Volver.TabStop = true;
            this.LL_Volver.Text = "Volver";
            this.LL_Volver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Volver_LinkClicked);
            // 
            // PN_Secretario
            // 
            this.PN_Secretario.Controls.Add(this.BTN_Actualizar);
            this.PN_Secretario.Controls.Add(this.BTN_BorrarTurno);
            this.PN_Secretario.Controls.Add(this.CMB_Turnos);
            this.PN_Secretario.Location = new System.Drawing.Point(706, 335);
            this.PN_Secretario.Name = "PN_Secretario";
            this.PN_Secretario.Size = new System.Drawing.Size(246, 114);
            this.PN_Secretario.TabIndex = 13;
            this.PN_Secretario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BTN_Actualizar
            // 
            this.BTN_Actualizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Actualizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Actualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Actualizar.Location = new System.Drawing.Point(70, 57);
            this.BTN_Actualizar.Name = "BTN_Actualizar";
            this.BTN_Actualizar.Size = new System.Drawing.Size(135, 28);
            this.BTN_Actualizar.TabIndex = 15;
            this.BTN_Actualizar.Text = "Actualizar Turno";
            this.BTN_Actualizar.UseVisualStyleBackColor = false;
            this.BTN_Actualizar.Click += new System.EventHandler(this.BTN_Actualizar_Click);
            // 
            // BTN_BorrarTurno
            // 
            this.BTN_BorrarTurno.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_BorrarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BorrarTurno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BorrarTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_BorrarTurno.Location = new System.Drawing.Point(160, 23);
            this.BTN_BorrarTurno.Name = "BTN_BorrarTurno";
            this.BTN_BorrarTurno.Size = new System.Drawing.Size(83, 28);
            this.BTN_BorrarTurno.TabIndex = 14;
            this.BTN_BorrarTurno.Text = "Eliminar";
            this.BTN_BorrarTurno.UseVisualStyleBackColor = false;
            this.BTN_BorrarTurno.Click += new System.EventHandler(this.BTN_BorrarTurno_Click);
            // 
            // CMB_Turnos
            // 
            this.CMB_Turnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Turnos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Turnos.FormattingEnabled = true;
            this.CMB_Turnos.Location = new System.Drawing.Point(3, 23);
            this.CMB_Turnos.Name = "CMB_Turnos";
            this.CMB_Turnos.Size = new System.Drawing.Size(151, 28);
            this.CMB_Turnos.TabIndex = 0;
            // 
            // TurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.PN_Secretario);
            this.Controls.Add(this.LL_Volver);
            this.Controls.Add(this.BTN_HistorialClinico);
            this.Controls.Add(this.DGV_Turnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TurnoForm";
            this.Text = "TurnoForm";
            this.Load += new System.EventHandler(this.TurnoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Turnos)).EndInit();
            this.PN_Secretario.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PN_Secretario;
        private System.Windows.Forms.Button BTN_Actualizar;
        private System.Windows.Forms.Button BTN_BorrarTurno;
        private System.Windows.Forms.ComboBox CMB_Turnos;
    }
}