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
            TXB_dni.TextChanged += CargarHistorialesEnCombo;
        }

        private void BTN_Cargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXB_dni.Text) ||
               string.IsNullOrWhiteSpace(TXB_name.Text) ||
               string.IsNullOrWhiteSpace(TXB_surname.Text) ||
               string.IsNullOrWhiteSpace(DTP_Fecha.Text) ||
               string.IsNullOrWhiteSpace(TXB_ObraSocial.Text) ||
               string.IsNullOrWhiteSpace(TXB_NumeroAfiliado.Text) ||
               string.IsNullOrWhiteSpace(CMB_HistoriaClinica.Text))
            {
                MessageBox.Show("No debe dejar campos vacíos.");
                return;
            }
            
            if (!int.TryParse(TXB_dni.Text, out int dni) ||
            !DateTime.TryParse(DTP_Fecha.Text, out DateTime fecha))
            {
                MessageBox.Show("DNI o fecha no válidos.");
                return;
            }
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
                    FechaNacimiento = DTP_Fecha.Value,
                    ObraSocial = TXB_ObraSocial.Text,
                    NumeroAfiliado = int.Parse(TXB_NumeroAfiliado.Text),
                    HistoriaClinicaId = (int)CMB_HistoriaClinica.SelectedValue
                };
            }
            MessageBox.Show("Registro completado correctamente.");
        }

        private void CargarHistorialesEnCombo(object sender, EventArgs e)
        {
            if (TXB_dni.Text.Length < 7) return;

            if (!int.TryParse(TXB_dni.Text, out int dni))
                return;

            using (var db = new ApplicationDBContextContainer())
            {
                var paciente = db.PersonaSet.OfType<Paciente>()
                                .FirstOrDefault(p => p.DNI == dni);

                if (paciente == null)
                {
                    CMB_HistoriaClinica.DataSource = null;
                    return;
                }

                var historiales = db.HistoriaClinicaSet
                    .Where(hc => hc.Id == paciente.HistoriaClinicaId)
                    .Select(hc => new { Id = hc.Id, Fecha = hc.FechaCreacion })
                    .ToList();

                CMB_HistoriaClinica.DataSource = historiales;
                CMB_HistoriaClinica.DisplayMember = "Fecha";
                CMB_HistoriaClinica.ValueMember = "Id";
            }
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AsignarTurnoForm asignarTurnoForm = new AsignarTurnoForm();
            this.Hide();
            asignarTurnoForm.Show();
        }

        private void BTN_CrearHistorialClinico_Click(object sender, EventArgs e)
        {
            CrearHistorialClinicoForm crearHistorialClinicoForm = new CrearHistorialClinicoForm();
            this.Hide();
            crearHistorialClinicoForm.Show();
        }

        private void TXB_dni_TextChanged(object sender, EventArgs e)
        {
            TXB_dni.TextChanged += CargarHistorialesEnCombo;
        }
    }
}
