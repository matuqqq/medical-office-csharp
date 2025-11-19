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
    public partial class DiagnosticoForm : Form
    {
        public DiagnosticoForm()
        {
            InitializeComponent();
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MedicoForm medicoForm = new MedicoForm();
            this.Close();
            medicoForm.Show();
        }
    }
}
