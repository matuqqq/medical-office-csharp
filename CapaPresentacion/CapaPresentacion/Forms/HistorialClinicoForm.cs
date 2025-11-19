using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaDatos.Clases.Datos;
using CapaDatos.Clases.Entities;
using CapaNegocio.Clases;

namespace CapaPresentacion.Forms
{
    public partial class HistorialClinicoForm : Form
    {
        public HistorialClinicoForm()
        {
            InitializeComponent();
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TurnoForm turnoForm = new TurnoForm();
            this.Close();
            turnoForm.Show();
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXB_PacienteId.Text))
            {
                MessageBox.Show("Complete el campo para poder realizar la busqueda");
                return;
            }
            using (var db = new ApplicationDBContextContainer())
            {
                int pacienteID = int.Parse(TXB_PacienteId.Text);
                var existe = db.PermisoSet.Any(p => p.Id == pacienteID);
                if(existe == true)
                {
                    DGV_HistorialClinico.DataSource = db.PermisoSet.Where(p => p.Id == pacienteID).ToList();
                }
            }
        }
    }
}
