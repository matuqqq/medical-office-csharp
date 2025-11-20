using CapaDatos;
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
    public partial class VerPacientesForm : Form
    {
        public VerPacientesForm()
        {
            InitializeComponent();
        }
        private void VerPacientesForm_Load(object sender, EventArgs e)
        {
        }
        private void CargarPacientes()
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var pacientes = db.PersonaSet
                    .OfType<Paciente>()
                    .Select(p => new
                    {
                        p.Id,
                        p.DNI,
                        p.Nombre,
                        p.Apellido,
                        FechaNacimiento = p.FechaNacimiento,
                        p.ObraSocial,
                        p.NumeroAfiliado,
                        p.HistoriaClinicaId
                    })
                    .ToList();

                DGV_Pacientes.DataSource = pacientes;
            }
        }

        private void DGV_Pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TXB_DNI.Text, out int dniBuscado))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            using (var db = new ApplicationDBContextContainer())
            {
                var paciente = db.PersonaSet
                    .OfType<Paciente>()
                    .Where(p => p.DNI == dniBuscado)
                    .ToList()
                    .Select(p => new
                    {
                        p.Id,
                        p.DNI,
                        p.Nombre,
                        p.Apellido,
                        FechaNacimiento = p.FechaNacimiento.ToShortDateString(),
                        p.ObraSocial,
                        p.NumeroAfiliado,
                        p.HistoriaClinicaId
                    })
                    .ToList();

                if (paciente.Count == 0)
                {
                    MessageBox.Show("No se encontró un paciente con ese DNI.");
                    return;
                }

                DGV_Pacientes.DataSource = paciente;
            }
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AsignarTurnoForm asignarTurnoForm = new AsignarTurnoForm();
            asignarTurnoForm.Show();
            this.Close();
        }

        private void VerPacientesForm_Load_1(object sender, EventArgs e)
        {
            CargarPacientes();
        }
    }
}
