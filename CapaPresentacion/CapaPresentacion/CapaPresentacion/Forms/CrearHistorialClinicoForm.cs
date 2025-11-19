using CapaDatos;
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
using CapaDatos.Clases.Entities;
using CapaDatos.Clases.Datos;

namespace CapaPresentacion.Forms
{
    public partial class CrearHistorialClinicoForm : Form
    {
        public CrearHistorialClinicoForm()
        {
            InitializeComponent();
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CargarPacienteForm cargarPacienteForm = new CargarPacienteForm();
            cargarPacienteForm.Show();
            this.Hide();
        }

        private void BTN_Crear_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(DTP_Fecha.Text, out DateTime fecha))
            {
                MessageBox.Show("Debes poner una fecha valida");
                return;
            }

            using (var db = new ApplicationDBContextContainer())
            {
                // Leer DNI
                if (!int.TryParse(TXB_dni.Text, out int pacienteDNI))
                {
                    MessageBox.Show("DNI inválido");
                    return;
                }

                // Buscar paciente por DNI
                var paciente = db.PersonaSet.OfType<Paciente>()
                                            .FirstOrDefault(p => p.DNI == pacienteDNI);

                // 1️⃣ Si el paciente NO existe
                if (paciente == null)
                {
                    MessageBox.Show("No existe un paciente con ese DNI. Debe crearse primero.");
                    return;
                }

                // 2️⃣ Si el paciente YA tiene historial → NO permitir crear otro
                if (paciente.HistoriaClinicaId != null && paciente.HistoriaClinicaId > 0)
                {
                    MessageBox.Show("El paciente ya tiene un historial clínico creado.");
                    return;
                }

                // 3️⃣ Crear historial
                var historial = new E_historiaClinica
                {
                    FechaCreacion = fecha
                };

                // Guardar historial con tu función de negocio
                var negocio = new N_HistorialMedico();
                negocio.CheckAndSave(historial);   // ← historial.Id queda asignado aquí

                // 4️⃣ Asignar el historial al paciente existente
                paciente.HistoriaClinicaId = historial.Id;

                db.SaveChanges();

                MessageBox.Show("Historial clínico creado correctamente.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
