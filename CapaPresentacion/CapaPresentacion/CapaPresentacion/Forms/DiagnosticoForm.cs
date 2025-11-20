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

        private void BTN_CargarDiagnostico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXB_PacienteId.Text) ||
                 string.IsNullOrWhiteSpace(RTXB_Diagnostico.Text) ||
                 string.IsNullOrWhiteSpace(TXB_Tratamiento.Text) ||
                 string.IsNullOrWhiteSpace(TXB_TurnoId.Text))
            {
                MessageBox.Show("Complete todos los campos antes de cargar el diagnóstico.");
                return;
            }

            if (!int.TryParse(TXB_PacienteId.Text, out int pacienteId))
            {
                MessageBox.Show("PacienteId inválido.");
                return;
            }

            if (!int.TryParse(TXB_TurnoId.Text, out int turnoId))
            {
                MessageBox.Show("TurnoId inválido.");
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
                    MessageBox.Show("Este paciente no tiene historial clínico.");
                    return;
                }

                var turno = db.TurnoSet.FirstOrDefault(t => t.Id == turnoId);

                if (turno == null)
                {
                    MessageBox.Show("No existe un turno con ese ID.");
                    return;
                }

                var consultaExistente = db.ConsultaSet.FirstOrDefault(c => c.TurnoId == turnoId);

                if (consultaExistente != null)
                {
                    MessageBox.Show("Ya existe un diagnóstico cargado para este turno.");
                    return;
                }

                if (turno.PacienteId != pacienteId)
                {
                    MessageBox.Show("El ID del paciente ingresado no coincide con el paciente asignado al turno.");
                    return;
                }

                if (SesionActual.MedicoId.HasValue == false || turno.MedicoId != SesionActual.MedicoId.Value)
                {
                    MessageBox.Show("Usted no es el médico asignado a este turno.");
                    return;
                }

                turno.Estado = 1;
                N_Turno n_Turno = new N_Turno();

                var result = new E_turno()
                {
                    Id = turno.Id,
                    Fecha = turno.Fecha,
                    Hora = turno.Hora,
                    Estado = turno.Estado,
                    PacienteId = turno.PacienteId,
                    MedicoId = turno.MedicoId
                };
                n_Turno.UpdateTurno(result);

                var consulta = new Consulta
                {
                    Fecha = DTP_Fecha.Value,
                    Diagnostico = RTXB_Diagnostico.Text,
                    Tratamiento = TXB_Tratamiento.Text,
                    TurnoId = turnoId,
                    HistoriaClinicaId = historial.Id
                };

                db.ConsultaSet.Add(consulta);
                db.SaveChanges();
            }

            MessageBox.Show("Diagnóstico cargado correctamente.");
        }
    }
}
