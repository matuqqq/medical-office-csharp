using CapaDatos;
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
    public partial class VerDiagnosticosForm : Form
    {
        public VerDiagnosticosForm()
        {
            InitializeComponent();
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MedicoForm f = new MedicoForm();
            this.Close();
            f.Show();
        }

        private void LL_Volver_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HistorialClinicoForm historialClinicoForm = new HistorialClinicoForm();
            this.Close();
            historialClinicoForm.Show();
        }

        private void BTN_Buscar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXB_PacienteId.Text))
            {
                MessageBox.Show("Ingrese el ID del paciente.");
                return;
            }

            if (!int.TryParse(TXB_PacienteId.Text, out int pacienteId))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            using (var db = new ApplicationDBContextContainer())
            {
                var paciente = db.PersonaSet.OfType<Paciente>()
                    .FirstOrDefault(p => p.Id == pacienteId);

                if (paciente == null)
                {
                    MessageBox.Show("No existe un paciente con ese ID.");
                    return;
                }

                var historial = db.HistoriaClinicaSet
                    .FirstOrDefault(h => h.PacienteId == paciente.Id);

                if (historial == null)
                {
                    MessageBox.Show("El paciente no tiene historial clínico.");
                    return;
                }

                var diagnosticos = db.ConsultaSet
                    .Where(c => c.HistoriaClinicaId == historial.Id)
                    .Select(c => new
                    {
                        c.Id,
                        c.Fecha,
                        c.Diagnostico,
                        c.Tratamiento,
                        c.TurnoId
                    })
                    .ToList();

                if (diagnosticos.Count == 0)
                {
                    MessageBox.Show("El paciente no tiene diagnósticos cargados.");
                    return;
                }

                DGV_Diagnosticos.DataSource = diagnosticos;
            }
        }

        private void TXB_PacienteId_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerDiagnosticosForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
