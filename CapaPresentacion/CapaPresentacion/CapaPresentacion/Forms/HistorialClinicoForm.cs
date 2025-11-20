using CapaDatos;
using CapaDatos.Clases.Datos;
using CapaDatos.Clases.Entities;
using CapaDatos.Clases.Utils;
using CapaNegocio.Clases;
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
    public partial class HistorialClinicoForm : Form
    {
        public HistorialClinicoForm()
        {
            InitializeComponent();
            if (SesionActual.EsMedico)
            {
                PN_Medico.Visible = true;
                PN_Secretario.Visible = false;
            }
            else
            {
                PN_Secretario.Visible = true;
                PN_Medico.Visible = false;
            }
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

            using (var db = new ApplicationDBContextContainer())
            {
                int pacienteId = int.Parse(TXB_PacienteId.Text);
                int paciente = db.PersonaSet.OfType<Paciente>()
                    .Where(p => p.Id == pacienteId)
                    .Select(p => p.Id)
                    .FirstOrDefault();

                if (paciente == null)
                {
                    MessageBox.Show("El paciente no existe.");
                    return;
                }

                var historial = db.HistoriaClinicaSet
                    .Where(h => h.PacienteId == pacienteId)
                    .Select(h => new
                    {
                        h.Id,
                        h.FechaCreacion,
                        Consultas = h.Consulta.Count
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

        private void BTN_VerDiagnosticos_Click(object sender, EventArgs e)
        {
            VerDiagnosticosForm diagnosticoForm = new VerDiagnosticosForm();
            this.Close();
            diagnosticoForm.Show();
        }

        private void HistorialClinicoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicoForm medicoForm = new MedicoForm();
            this.Close();
            medicoForm.Show();
        }

        private void BTN_VolverSecretario_Click(object sender, EventArgs e)
        {
            SecretarioForm secretarioForm = new SecretarioForm();
            this.Close();
            secretarioForm.Show();
        }
    }
}
