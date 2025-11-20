using CapaDatos;
using CapaDatos.Clases.Utils;
using Microsoft.Win32;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_login_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXB_dni.Text) ||
                string.IsNullOrWhiteSpace(TXB_name.Text) ||
                string.IsNullOrWhiteSpace(TXB_surname.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            if (!int.TryParse(TXB_dni.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                return;
            }

            using (var db = new ApplicationDBContextContainer())
            {
                var persona = db.PersonaSet.FirstOrDefault(p => p.DNI == dni);

                if (persona == null)
                {
                    MessageBox.Show("Persona no registrada.");
                    return;
                }

                SesionActual.PersonaId = persona.Id;
                SesionActual.NombreCompleto = persona.Nombre + " " + persona.Apellido;
                SesionActual.EsMedico = false;
                SesionActual.EsSecretario = false;
                SesionActual.MedicoId = null;
                SesionActual.SecretarioId = null;

                if (persona is Medico medico)
                {
                    SesionActual.EsMedico = true;
                    SesionActual.MedicoId = medico.Id;

                    MessageBox.Show($"Bienvenido Dr. {SesionActual.NombreCompleto}");
                    MedicoForm medicoForm = new MedicoForm();
                    this.Hide();
                    medicoForm.Show();
                }
                else if (persona is Secretario secretario)
                {
                    SesionActual.EsSecretario = true;
                    SesionActual.SecretarioId = secretario.Id;

                    MessageBox.Show($"Bienvenido Secretario {SesionActual.NombreCompleto}");
                    SecretarioForm secretarioForm = new SecretarioForm();
                    this.Hide();
                    secretarioForm.Show();
                }
                else if (persona is Personal)
                {
                    MessageBox.Show("El usuario pertenece al personal, pero no tiene un rol específico.");
                }
                else
                {
                    MessageBox.Show("Tipo de usuario desconocido.");
                }
            }
        }

        private void LL_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                Registro registro = new Registro();
                this.Hide();
                registro.Show();
            }
        }
    }
}
