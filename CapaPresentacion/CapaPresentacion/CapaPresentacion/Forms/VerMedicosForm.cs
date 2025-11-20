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
    public partial class VerMedicosForm : Form
    {
        public VerMedicosForm()
        {
            InitializeComponent();
        }

        private void VerMedicosForm_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            BuscarPorDNI();
        }

        private void CargarTodosLosMedicos()
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var medicos = db.PersonaSet.OfType<Medico>()
                                .Select(m => new
                                {
                                    m.Id,
                                    m.Nombre,
                                    m.Apellido,
                                    m.DNI,
                                    m.Especialidad
                                })
                                .ToList();

                DGV_Medicos.DataSource = medicos;
            }
        }

        private void BuscarPorDNI()
        {
            if (string.IsNullOrWhiteSpace(TXB_DNI.Text))
            {
                MessageBox.Show("Ingrese un DNI para buscar.");
                return;
            }

            int dniBuscado;
            if (!int.TryParse(TXB_DNI.Text, out dniBuscado))
            {
                MessageBox.Show("El DNI debe ser un número.");
                return;
            }

            using (var db = new ApplicationDBContextContainer())
            {
                var medico = db.PersonaSet.OfType<Medico>()
                               .Where(m => m.DNI == dniBuscado)
                               .Select(m => new
                               {
                                   m.Id,
                                   m.Nombre,
                                   m.Apellido,
                                   m.DNI,
                                   m.Especialidad
                               })
                               .ToList();

                if (medico.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún médico con ese DNI.");
                    return;
                }

                DGV_Medicos.DataSource = medico;
            }
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AsignarTurnoForm asignarTurnoForm = new AsignarTurnoForm();
            asignarTurnoForm.Show();
            this.Close();
        }

        private void VerMedicosForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                CargarTodosLosMedicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message + "\n\n" + ex.StackTrace);
            }
        }
    }
}
