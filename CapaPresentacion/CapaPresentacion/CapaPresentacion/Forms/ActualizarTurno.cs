using CapaDatos.Clases.Entities;
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
    public partial class ActualizarTurno : Form
    {
        private readonly N_Turno nTurno = new N_Turno();
        private E_turno turnoActual;
        public ActualizarTurno()
        {
            InitializeComponent();
        }

        private void BTN_Actualizar_Click(object sender, EventArgs e)
        {
            if (turnoActual == null)
            {
                MessageBox.Show("Primero busque un turno.");
                return;
            }

            turnoActual.Fecha = DTP_Fecha.Value;
            turnoActual.Hora = TXB_Hora.Text;

            if (CHB_Completado.Checked == true)
            {
                turnoActual.Estado = 1;
            }
            else
            {
                turnoActual.Estado = 0;
            }

            if (!int.TryParse(TXB_MedicoId.Text, out int medicoId))
            {
                MessageBox.Show("MedicoId inválido.");
                return;
            }

            turnoActual.MedicoId = medicoId;

            bool actualizado = nTurno.UpdateTurno(turnoActual);
            if (actualizado)
                MessageBox.Show("Turno actualizado correctamente.");
            else
                MessageBox.Show("Error al actualizar el turno.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_BuscarTurno_Click(object sender, EventArgs e)
        {
            if (turnoActual == null)
            {
                MessageBox.Show("No se encontró un turno con ese ID.");
                return;
            }

            DTP_Fecha.Value = turnoActual.Fecha;
            TXB_Hora.Text = turnoActual.Hora;
            if(turnoActual.Estado == 0)
                CHB_Completado.Checked = false;
            else
                CHB_Completado.Checked = true;
            TXB_MedicoId.Text = turnoActual.MedicoId.ToString();
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           TurnoForm turnoForm = new TurnoForm();
              turnoForm.Show();
                this.Hide();
        }

        public ActualizarTurno(int turnoId)
        {
            InitializeComponent();
            CargarTurno(turnoId);
        }

        private void CargarTurno(int turnoId)
        {
            turnoActual = nTurno.GetTurnoById(turnoId);

            if (turnoActual == null)
            {
                MessageBox.Show("No se encontró un turno con ese ID.");
                this.Close();
                return;
            }

            DTP_Fecha.Value = turnoActual.Fecha;
            TXB_Hora.Text = turnoActual.Hora;
            CHB_Completado.Checked = turnoActual.Estado == 1;
            TXB_MedicoId.Text = turnoActual.MedicoId.ToString();
        }

        private void ActualizarTurno_Load(object sender, EventArgs e)
        {
           
        }

        private void BTN_ActualizarTurno_Click(object sender, EventArgs e)
        {
            if (turnoActual == null)
            {
                MessageBox.Show("Primero busque un turno.");
                return;
            }

            turnoActual.Fecha = DTP_Fecha.Value;
            turnoActual.Hora = TXB_Hora.Text;

            if (CHB_Completado.Checked == true)
            {
                turnoActual.Estado = 1;
            }
            else
            {
                turnoActual.Estado = 0;
            }

            if (!int.TryParse(TXB_MedicoId.Text, out int medicoId))
            {
                MessageBox.Show("MedicoId inválido.");
                return;
            }

            turnoActual.MedicoId = medicoId;

            bool actualizado = nTurno.UpdateTurno(turnoActual);
            if (actualizado)
                MessageBox.Show("Turno actualizado correctamente.");
            else
                MessageBox.Show("Error al actualizar el turno.");
        }
    }
}
