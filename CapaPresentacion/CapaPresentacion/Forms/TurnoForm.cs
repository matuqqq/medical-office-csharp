using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class TurnoForm : Form
    {
        public TurnoForm()
        {
            InitializeComponent();
        }

        private void TurnoForm_Load(object sender, EventArgs e)
        {

        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MedicoForm medicoForm = new MedicoForm();
            this.Close();
            medicoForm.Show();
        }

        private void BTN_HistorialClinico_Click(object sender, EventArgs e)
        {
            HistorialClinicoForm historialClinicoForm = new HistorialClinicoForm();
            this.Hide();
            historialClinicoForm.Show();
        }
    }
}
