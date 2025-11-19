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

            // Validar y actualizar campos
            turnoActual.Fecha = DTP_Fecha.Value;
            turnoActual.Hora = TXB_Hora.Text;

            if (!int.TryParse(TXB_Estado.Text, out int estado))
            {
                MessageBox.Show("Estado inválido.");
                return;
            }

            if (!int.TryParse(TXB_MedicoId.Text, out int medicoId))
            {
                MessageBox.Show("MedicoId inválido.");
                return;
            }

            turnoActual.Estado = estado;
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
            if (!int.TryParse(TXB_TurnoId.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            turnoActual = nTurno.GetTurnoById(id);
            if (turnoActual == null)
            {
                MessageBox.Show("No se encontró un turno con ese ID.");
                return;
            }

            // Mostrar los datos actuales
            DTP_Fecha.Value = turnoActual.Fecha;
            TXB_Hora.Text = turnoActual.Hora;
            TXB_Estado.Text = turnoActual.Estado.ToString();
            TXB_MedicoId.Text = turnoActual.MedicoId.ToString();
        }
    }
}
