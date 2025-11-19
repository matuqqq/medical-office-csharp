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
    public partial class CargarPacienteForm : Form
    {
        public CargarPacienteForm()
        {
            InitializeComponent();
        }

        private void BTN_Cargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXB_dni.Text) ||
               string.IsNullOrWhiteSpace(TXB_name.Text) ||
               string.IsNullOrWhiteSpace(TXB_surname.Text) ||
               string.IsNullOrWhiteSpace(TXB_borndate.Text) ||
               string.IsNullOrWhiteSpace(TXB_ObraSocial.Text) ||
               string.IsNullOrWhiteSpace(TXB_NumeroAfiliado.Text) ||
               string.IsNullOrWhiteSpace(TXB_HistoriaClinicaId.Text))
            {
                MessageBox.Show("No debe dejar campos vacíos.");
                return;
            }
            
            if (!int.TryParse(TXB_dni.Text, out int dni) ||
            !DateTime.TryParse(TXB_borndate.Text, out DateTime fecha))
            {
                MessageBox.Show("DNI o fecha no válidos.");
                return;
            }
            Paciente paciente = new Paciente();
            using (var db = new ApplicationDBContextContainer())
            {
                if (db.PersonaSet.Any(p => p.DNI == dni))
                {
                    MessageBox.Show("La persona ya existe.");
                    return;
                }

                var pacient = new Paciente
                {
                    DNI = int.Parse(TXB_dni.Text),
                    Nombre = TXB_name.Text,
                    Apellido = TXB_surname.Text,
                    FechaNacimiento = Convert.ToDateTime(TXB_borndate.Text),
                    ObraSocial = TXB_ObraSocial.Text,
                    NumeroAfiliado = int.Parse(TXB_NumeroAfiliado.Text),
                    HistoriaClinicaId = int.Parse(TXB_HistoriaClinicaId.Text)
                };
            }
            paciente.Id++;
            MessageBox.Show("Registro completado correctamente.");
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AsignarTurnoForm asignarTurnoForm = new AsignarTurnoForm();
            this.Close();
            asignarTurnoForm.Show();
        }
    }
}
