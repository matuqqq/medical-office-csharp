using CapaDatos;
using CapaDatos.Clases.Datos;
using CapaDatos.Clases.Entities;
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
    public partial class TurnoForm : Form
    {
        public TurnoForm()
        {
            InitializeComponent();
        }

        private void TurnoForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.EsMedico)
            {
                PN_Secretario.Visible = false;
                CargarTurnosMedico(SesionActual.MedicoId ?? 0);
            }
            else if (SesionActual.EsSecretario)
            {
                PN_Secretario.Visible = true;
                CargarTodosLosTurnos();
            }
            else
            {
                MessageBox.Show("No se pudo determinar el rol del usuario.");
                this.Close();
            }

            CargarDGV();
        }


        private void CargarTurnosMedico(int medicoId)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var turnosRaw = db.TurnoSet
                    .Where(t => t.MedicoId == medicoId)
                    .Select(t => new { t.Id, t.Fecha, t.Hora })
                    .ToList();

                if (turnosRaw.Count == 0)
                {
                    CMB_Turnos.DataSource = null;
                    CMB_Turnos.Items.Clear();
                    CMB_Turnos.Text = "";
                    return;
                }

                var turnos = turnosRaw
                    .Select(t => new
                    {
                        t.Id,
                        Descripcion = "Turno #" + t.Id + " - " + t.Fecha.ToShortDateString() + " " + t.Hora
                    })
                    .ToList();

                CMB_Turnos.DisplayMember = "Descripcion";
                CMB_Turnos.ValueMember = "Id";
                CMB_Turnos.DataSource = turnos;
            }
        }

        private void CargarTodosLosTurnos()
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var turnosRaw = db.TurnoSet
                    .Select(t => new { t.Id, t.Fecha, t.Hora })
                    .ToList();

                if (turnosRaw.Count == 0)
                {
                    CMB_Turnos.DataSource = null;
                    CMB_Turnos.Items.Clear();
                    CMB_Turnos.Text = "";
                    return;
                }

                var turnos = turnosRaw
                    .Select(t => new
                    {
                        t.Id,
                        Descripcion = "Turno #" + t.Id + " - " + t.Fecha.ToShortDateString() + " " + t.Hora
                    })
                    .ToList();

                CMB_Turnos.DisplayMember = "Descripcion";
                CMB_Turnos.ValueMember = "Id";
                CMB_Turnos.DataSource = turnos;
            }
        }

        private void BTN_BorrarTurno_Click(object sender, EventArgs e)
        {
            if (CMB_Turnos.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un turno para eliminar.");
                return;
            }

            int turnoId = (int)CMB_Turnos.SelectedValue;

            var confirm = MessageBox.Show($"¿Seguro que desea eliminar el turno #{turnoId}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            using (var db = new ApplicationDBContextContainer())
            {
                var turno = db.TurnoSet.FirstOrDefault(t => t.Id == turnoId);
                if (turno == null)
                {
                    MessageBox.Show("El turno no existe o ya fue eliminado.");
                    return;
                }
                D_turno d = new D_turno();
                d.Delete(turnoId);
            }

            MessageBox.Show("Turno eliminado correctamente.");

            if (SesionActual.EsMedico)
                CargarTurnosMedico(SesionActual.MedicoId ?? 0);
            else if (SesionActual.EsSecretario)
                CargarTodosLosTurnos();
            CMB_Turnos.Text = "";
            CargarDGV();
        }


        private void CargarDGV()
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var turnosRaw = db.TurnoSet
                    .Select(t => new
                    {
                        t.Id,
                        t.Fecha,
                        t.Hora,
                        Estado = t.Estado == 0 ? "Pendiente" :
                                 t.Estado == 1 ? "Confirmado" : "Cancelado",
                        Paciente = t.PacienteId + " ",
                        Medico = t.Medico.Nombre + " " + t.Medico.Apellido
                    })
                    .ToList();

                var turnos = turnosRaw
                    .Select(t => new
                    {
                        t.Id,
                        Fecha = t.Fecha.ToShortDateString(),
                        t.Hora,
                        t.Estado,
                        t.Paciente,
                        t.Medico
                    })
                    .ToList();

                DGV_Turnos.DataSource = turnos;
                DGV_Turnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SesionActual.EsMedico)
            {
                MedicoForm medicoForm = new MedicoForm();
                this.Close();
                medicoForm.Show();
            }
            else if (SesionActual.EsSecretario)
            {
                SecretarioForm secretarioForm = new SecretarioForm();
                this.Close();
                secretarioForm.Show();
            }
        }

        private void BTN_HistorialClinico_Click(object sender, EventArgs e)
        {
            HistorialClinicoForm historialClinicoForm = new HistorialClinicoForm();
            this.Hide();
            historialClinicoForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BTN_Actualizar_Click(object sender, EventArgs e)
        {
            if (CMB_Turnos.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un turno.");
                return;
            }

            int turnoId = (int)CMB_Turnos.SelectedValue;

            ActualizarTurno actualizarTurno = new ActualizarTurno(turnoId);
            this.Hide();
            actualizarTurno.Show();
        }
    }
}
