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
                MessageBox.Show("Complete el campo para poder realizar la búsqueda.");
                return;
            }

            int pacienteID = int.Parse(TXB_PacienteId.Text);

            using (var db = new ApplicationDBContextContainer())
            {
                var historial = db.HistoriaClinicaSet
                    .Where(h => h.PacienteId == pacienteID)
                    .Select(h => new
                    {
                        h.Id,
                        h.FechaCreacion,
                        h.Consulta
                    })
                    .ToList();

                if (historial.Count == 0)
                {
                    MessageBox.Show("El paciente no tiene historial clínico.");
                    return;
                }

                DGV_HistorialClinico.DataSource = historial;
            }
        }
    }
}
