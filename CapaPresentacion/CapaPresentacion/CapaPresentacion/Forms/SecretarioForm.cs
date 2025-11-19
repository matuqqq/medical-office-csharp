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
    }
}
