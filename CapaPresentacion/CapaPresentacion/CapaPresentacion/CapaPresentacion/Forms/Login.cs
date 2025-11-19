using CapaDatos;
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
            {
                if (TXB_dni.Text != "" && TXB_name.Text != "" && TXB_surname.Text != "")
                {

                    using (ApplicationDBContextContainer db = new ApplicationDBContextContainer())
                    {
                        Console.WriteLine(TXB_name.Text + TXB_surname.Text);
                        System.Linq.Expressions.Expression<Func<Usuario, bool>> predicate = p => p.NombreUsuario == TXB_name.Text + TXB_surname.Text;
                        bool existe = db.UsuarioSet.Any(predicate);
                        if (existe)
                        {
                            MedicoForm medicoForm = new MedicoForm();
                            this.Hide();
                            medicoForm.Show();
                        }
                        else
                            MessageBox.Show("Persona no registrada.");
                    }
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
