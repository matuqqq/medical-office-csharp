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
    public partial class MedicoForm : Form
    {
        public MedicoForm()
        {
            InitializeComponent();
        }

        private void BTN_VerTurno_Click(object sender, EventArgs e)
        {
            TurnoForm turnoForm = new TurnoForm();
            this.Hide();
            turnoForm.Show();
        }

        private void BTN_Diagnosticar_Click(object sender, EventArgs e)
        {
            DiagnosticoForm diagnosticoForm = new DiagnosticoForm();
            this.Hide();
            diagnosticoForm.Show();
        }
    }
}
