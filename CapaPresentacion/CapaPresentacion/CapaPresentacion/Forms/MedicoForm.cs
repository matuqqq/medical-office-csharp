using CapaDatos.Clases.Utils;
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

        }

        private void BTN_Diagnosticar_Click(object sender, EventArgs e)
        {

        }

        private void BTN_VerHistorialClinico_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {

        }

        private void MedicoForm_Load(object sender, EventArgs e)
        {

        }

        private void BTN_AsignarTurno_Click(object sender, EventArgs e)
        {
            TurnoForm turnoForm = new TurnoForm();
            this.Hide();
            turnoForm.Show();
        }

        private void BTN_VerHistorialClinico_Click_1(object sender, EventArgs e)
        {
            HistorialClinicoForm historialClinicoForm = new HistorialClinicoForm();
            historialClinicoForm.Show();
            this.Hide();
        }

        private void BTN_Diagnosticar_Click_1(object sender, EventArgs e)
        {
            DiagnosticoForm diagnosticoForm = new DiagnosticoForm();
            this.Hide();
            diagnosticoForm.Show();
        }

        private void BTN_Salir_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }
    }
}
