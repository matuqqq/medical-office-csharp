using CapaDatos;
using CapaDatos.Clases.Datos;
using CapaDatos.Clases.Entities;
using CapaNegocio.Clases;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void BTN_register_Click(object sender, EventArgs e)
        {
            if (!CHB_medic.Checked && !CHB_secretario.Checked)
            {
                MessageBox.Show("Debe seleccionar Médico o Secretario.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TXB_dni.Text) ||
                string.IsNullOrWhiteSpace(TXB_name.Text) ||
                string.IsNullOrWhiteSpace(TXB_surname.Text) ||
                string.IsNullOrWhiteSpace(DTP_Fecha.Text) ||
                string.IsNullOrWhiteSpace(TXB_email.Text) ||
                string.IsNullOrWhiteSpace(TXB_legajo.Text) ||
                string.IsNullOrWhiteSpace(TXB_phone.Text))
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
            }

            if (CHB_medic.Checked)
            {

                var medico = new E_medico
                {
                    Nombre = TXB_name.Text,
                    Apellido = TXB_surname.Text,
                    DNI = dni,
                    FechaNacimiento = fecha,
                    Legajo = int.Parse(TXB_legajo.Text),
                    Email = TXB_email.Text,
                    Telefono = int.Parse(TXB_phone.Text),
                    Matricula = TXB_matricula.Text,
                    EspecialidadId = (int)CMB_Especialidades.SelectedValue
                };

                new N_medico().CheckAndSave(medico);
            }
            else
            {
                if (!DateTime.TryParse(TXB_horarioentrada.Text, out DateTime entrada) ||
                    !DateTime.TryParse(TXB_horariosalida.Text, out DateTime salida))
                {
                    MessageBox.Show("Los horarios deben tener un formato de hora válido.");
                    return;
                }

                var secretario = new E_secretario
                {
                    DNI = dni,
                    Nombre = TXB_name.Text,
                    Apellido = TXB_surname.Text,
                    FechaNacimiento = fecha,
                    Email = TXB_email.Text,
                    Legajo = int.Parse(TXB_legajo.Text),
                    Telefono = int.Parse(TXB_phone.Text),
                    HorarioEntrada = entrada,
                    HorarioSalida = salida
                };

                new N_secretario().CheckAndSave(secretario);
            }

            MessageBox.Show("Registro completado correctamente.");
        }

        private void LL_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void CHB_medic_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_medic.Checked)
            {
                CHB_secretario.Checked = false;
                PN_secretary.Visible = false;
                PN_medic.Visible = true;
            }
            else
            {
                PN_medic.Visible = false;

                if (!CHB_secretario.Checked)
                {
                    PN_secretary.Visible = false;
                }
            }
        }

        private void CHB_secretario_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_secretario.Checked)
            {
                CHB_medic.Checked = false;
                PN_medic.Visible = false;
                PN_secretary.Visible = true;
            }
            else
            {
                PN_secretary.Visible = false;

                if (!CHB_medic.Checked)
                {
                    PN_medic.Visible = false;
                }
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            PN_medic.Visible = false;
            PN_secretary.Visible = false;
            var especialidades = new D_Especialidad().GetAllEspecialidades();

            CMB_Especialidades.DataSource = especialidades;
            CMB_Especialidades.DisplayMember = "NombreEspecialidad";
            CMB_Especialidades.ValueMember = "Id";
        }

        private void BTN_AgregarEspecialidad_Click(object sender, EventArgs e)
        {
            EspecialidadForm especialidadForm = new EspecialidadForm();
            especialidadForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TXB_dni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

