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
            if (string.IsNullOrWhiteSpace(TXB_Estado.Text) ||
                string.IsNullOrWhiteSpace(TXB_Fecha.Text) ||
                string.IsNullOrWhiteSpace(TXB_Hora.Text) ||
                string.IsNullOrWhiteSpace(TXB_MedicoId.Text) ||
                string.IsNullOrWhiteSpace(TXB_PacienteId.Text))
            {
                MessageBox.Show("No deje campos vacios");
                return;
            }
            if (!DateTime.TryParse(TXB_Fecha.Text, out DateTime fecha))
            {
                MessageBox.Show("fecha no válida.");
                return;
            }
            using (var db = new ApplicationDBContextContainer())
            {
                int medicoId = int.Parse(TXB_MedicoId.Text);
                if (db.PersonaSet.Any(p => p.DNI == medicoId))
                {
                    int pacienteID = int.Parse(TXB_PacienteId.Text);
                    if (db.PersonaSet.Any(p => p.Id == pacienteID))
                    {
                        var turno = new E_turno
                        {
                            Id = +1,
                            Fecha = Convert.ToDateTime(TXB_Fecha.Text),
                            Estado = Convert.ToInt32(TXB_Estado.Text),
                            Hora = TXB_Hora.Text,
                            PacienteId = Convert.ToInt32(TXB_PacienteId),
                            MedicoId = Convert.ToInt32(TXB_MedicoId)
                        };
                    }
                    else
                    {
                        MessageBox.Show("El paciente no existe, porfavor cargarlo al sistema");
                        return;
                    }
  
                
            
                }
                else
                {
                    MessageBox.Show("El Medico no existe");
                    return;
                }
            }
        }

        private void BTN_AgregarPaciente_Click(object sender, EventArgs e)
        {
            CargarPacienteForm cargarPacienteForm = new CargarPacienteForm();
            this.Close();
            cargarPacienteForm.Show();
        }
    }
}
