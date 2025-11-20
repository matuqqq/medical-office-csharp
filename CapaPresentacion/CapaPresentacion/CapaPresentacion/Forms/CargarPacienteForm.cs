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

        N_Paciente n = new N_Paciente();
        N_HistorialMedico n_HistorialMedico = new N_HistorialMedico();
        public CargarPacienteForm()
        {
            InitializeComponent();
        }

        private void BTN_Cargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXB_dni.Text) ||
                string.IsNullOrWhiteSpace(TXB_name.Text) ||
                string.IsNullOrWhiteSpace(TXB_surname.Text) ||
                string.IsNullOrWhiteSpace(TXB_ObraSocial.Text) ||
                string.IsNullOrWhiteSpace(TXB_NumeroAfiliado.Text))
            {
                MessageBox.Show("No debe dejar campos vacíos.");
                return;
            }

            if (!int.TryParse(TXB_dni.Text, out int dni))
            {
                MessageBox.Show("DNI inválido.");
                return;
            }

            using (var db = new ApplicationDBContextContainer())
            {
                if (db.PersonaSet.Any(p => p.DNI == dni))
                {
                    MessageBox.Show("La persona ya existe en el sistema.");
                    return;
                }

                var paciente = new Paciente
                {
                    DNI = dni,
                    Nombre = TXB_name.Text,
                    Apellido = TXB_surname.Text,
                    FechaNacimiento = DTP_Fecha.Value,
                    ObraSocial = TXB_ObraSocial.Text,
                    NumeroAfiliado = int.Parse(TXB_NumeroAfiliado.Text)
                };

                db.PersonaSet.Add(paciente);
                db.SaveChanges(); 

                var historial = new HistoriaClinica
                {
                    FechaCreacion = DateTime.Now,
                    PacienteId = paciente.Id
                };

                db.HistoriaClinicaSet.Add(historial);
                db.SaveChanges();

                paciente.HistoriaClinicaId = historial.Id;
                db.SaveChanges();
            }

            MessageBox.Show("Paciente cargado correctamente con historial clínico asignado.");
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AsignarTurnoForm asignarTurnoForm = new AsignarTurnoForm();
            this.Hide();
            asignarTurnoForm.Show();
        }

        private void BTN_CrearHistorialClinico_Click(object sender, EventArgs e)
        {
        }

        private void CargarPacienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
