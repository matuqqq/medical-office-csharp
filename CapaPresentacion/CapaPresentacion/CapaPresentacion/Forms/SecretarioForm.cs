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
    public partial class SecretarioForm : Form
    {
        public SecretarioForm()
        {
            InitializeComponent();
        }

        private void BTN_AsignarTurno_Click(object sender, EventArgs e)
        {
            AsignarTurnoForm asignarTurnoForm = new AsignarTurnoForm();
            this.Hide();
            asignarTurnoForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurnoForm turnoForm = new TurnoForm();
            this.Hide();
            turnoForm.Show();
        }

        private void BTN_VerHistorialClinico_Click(object sender, EventArgs e)
        {
            HistorialClinicoForm historialClinicoForm = new HistorialClinicoForm();
            this.Close();
            historialClinicoForm.Show();
        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void SecretarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
