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
using CapaDatos.Clases.Entities;
using CapaNegocio.Clases;

namespace CapaPresentacion.Forms
{
    public partial class AsignarTurnoForm : Form
    {
        N_Turno n = new N_Turno();

        public AsignarTurnoForm()
        {
            InitializeComponent();
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SecretarioForm secretarioForm = new SecretarioForm();
            this.Close();
            secretarioForm.Show();
        }

        private void BTN_CargarTurno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DTP_Fecha.Text) ||
                string.IsNullOrWhiteSpace(TXB_Hora.Text) ||
                string.IsNullOrWhiteSpace(TXB_MedicoId.Text) ||
                string.IsNullOrWhiteSpace(TXB_PacienteId.Text))
            {
                MessageBox.Show("No deje campos vacíos.");
                return;
            }

            if (!DateTime.TryParse(DTP_Fecha.Text, out DateTime fecha))
            {
                MessageBox.Show("Fecha no válida.");
                return;
            }

            if (!int.TryParse(TXB_MedicoId.Text, out int medicoId))
            {
                MessageBox.Show("MedicoId inválido.");
                return;
            }

            if (!int.TryParse(TXB_PacienteId.Text, out int pacienteId))
            {
                MessageBox.Show("PacienteId inválido.");
                return;
            }

            string hora = TXB_Hora.Text.Trim();

            using (var db = new ApplicationDBContextContainer())
            {
                var medico = db.PersonaSet.OfType<Medico>().FirstOrDefault(m => m.Id == medicoId);
                if (medico == null)
                {
                    MessageBox.Show("El médico no existe.");
                    return;
                }

                var paciente = db.PersonaSet.OfType<Paciente>().FirstOrDefault(p => p.Id == pacienteId);
                if (paciente == null)
                {
                    MessageBox.Show("El paciente no existe, por favor cárguelo al sistema.");
                    return;
                }

                bool conflicto = db.TurnoSet.Any(x =>
                    x.MedicoId == medicoId &&
                    System.Data.Entity.DbFunctions.TruncateTime(x.Fecha) == fecha.Date &&
                    x.Hora.Trim() == hora
                );

                if (conflicto)
                {
                    MessageBox.Show("Conflicto: ese médico ya tiene un turno en la misma fecha y hora.");
                    return;
                }

                var turno = new E_turno
                {
                    Fecha = fecha,
                    Hora = hora,
                    Estado = 0,
                    PacienteId = pacienteId,
                    MedicoId = medicoId
                };

                try
                {
                    bool ok = n.CheckAndSave(turno);
                    if (ok)
                    {
                        MessageBox.Show("Turno creado correctamente.");             
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el turno.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar turno: " + ex.Message);
                }
            }
        }

        private void BTN_AgregarPaciente_Click(object sender, EventArgs e)
        {
            CargarPacienteForm cargarPacienteForm = new CargarPacienteForm();
            this.Close();
            cargarPacienteForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerPacientesForm verPacientesForm = new VerPacientesForm();
            verPacientesForm.Show();
            this.Hide();
        }

        private void BTN_VerMedicos_Click(object sender, EventArgs e)
        {
            VerMedicosForm verMedicosForm = new VerMedicosForm();
            verMedicosForm.Show();
            this.Hide();
        }

        private void AsignarTurnoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
