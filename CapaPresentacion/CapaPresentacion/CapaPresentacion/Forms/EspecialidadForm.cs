using CapaDatos.Clases.Datos;
using CapaDatos.Clases.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Clases;

namespace CapaPresentacion.Forms
{
    public partial class EspecialidadForm : Form
    {
        public EspecialidadForm()
        {
            InitializeComponent();
        }

        private void LL_Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Close();
        }

        private void BTN_Cargar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TXB_EspecialidadNom.Text))
            {
                MessageBox.Show("El nombre de la especialidad no puede estar vacío.");
                return;
            }
            var nuevaEspecialidad = new E_especialidad
            {
                NombreEspecialidad = TXB_EspecialidadNom.Text
            };

            var negocio = new N_Especialidad();

            try
            {
                if (negocio.CheckAndSave(nuevaEspecialidad))
                {
                    MessageBox.Show("Especialidad guardada correctamente.");
                    Registro registro = new Registro();
                    registro.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
