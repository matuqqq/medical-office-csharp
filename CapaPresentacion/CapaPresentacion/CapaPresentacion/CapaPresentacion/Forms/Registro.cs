using CapaDatos;
using CapaDatos.Clases.Entities;
using CapaNegocio.Clases;
using System;
using System.Linq;
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
            if (!CHB_secretario.Checked && !CHB_medic.Checked)
            {
                throw new Exception("Debe marcar como checkeado alguna de las dos opciones");
            }
            else if (CHB_medic.Checked == true)
            {
                using (ApplicationDBContextContainer db = new ApplicationDBContextContainer())
                {
                    E_usuario user = new E_usuario();
                    user.NombreUsuario = TXB_name.Text + TXB_surname.Text;
                    bool existe = db.UsuarioSet.Any(p => p.NombreUsuario == user.NombreUsuario);

                    if (existe)
                    {
                        MessageBox.Show("La persona ya existe en la base de datos.");
                    }
                    else
                    {
                        CHB_secretario.Checked = false;
                        PN_secretary.Visible = false;
                        PN_medic.Visible = true;
                        if (TXB_dni.Text != "" && TXB_name.Text != "" && TXB_surname.Text != "" && TXB_borndate.Text != "" && TXB_email.Text != "" && TXB_legajo.Text != "" && TXB_phone.Text != "" && TXB_matricula.Text != "")
                        {
                            N_medico nMedico = new N_medico();
                            E_medico medico = new E_medico();
                            N_usuario Nuser = new N_usuario();
                            user.Id++;
                            user.Rol = true;
                            user.PasswordHash = TXB_password.Text;
                            medico.DNI = int.Parse(TXB_dni.Text);
                            medico.Nombre = TXB_name.Text;
                            medico.Apellido = TXB_surname.Text;
                            medico.FechaNacimiento = Convert.ToDateTime(TXB_borndate.Text);
                            medico.Email = TXB_email.Text;
                            medico.Legajo = int.Parse(TXB_legajo.Text);
                            medico.Telefono = int.Parse(TXB_phone.Text);
                            medico.Matricula = TXB_matricula.Text;
                            nMedico.CheckAndSave(medico);
                            Nuser.CheckAndSave(user);
                        }
                        else
                        {
                            throw new Exception("No debe dejar ningun campo vacio");
                        }
                    }
                }
            }
            else if (CHB_secretario.Checked == true)
            {

                using (ApplicationDBContextContainer db = new ApplicationDBContextContainer())
                {
                    E_usuario user = new E_usuario();
                    user.NombreUsuario = TXB_name.Text + TXB_surname.Text;
                    bool existe = db.UsuarioSet.Any(p => p.NombreUsuario == user.NombreUsuario);

                    if (existe)
                    {
                        MessageBox.Show("La persona ya existe en la base de datos.");
                    }
                    {
                        CHB_medic.Checked = false;
                        PN_medic.Visible = false;
                        PN_secretary.Visible = true;
                        if (TXB_dni.Text != "" && TXB_name.Text != "" && TXB_surname.Text != "" && TXB_borndate.Text != "" && TXB_email.Text != "" && TXB_legajo.Text != "" && TXB_phone.Text != "" && TXB_matricula.Text != "")
                        {
                            E_secretario secretario = new E_secretario();
                            N_secretario n_Secretario = new N_secretario();
                            N_usuario Nuser = new N_usuario();
                            user.Id++;
                            user.Rol = true;
                            user.PasswordHash = TXB_password.Text;
                            secretario.DNI = int.Parse(TXB_dni.Text);
                            secretario.Nombre = TXB_name.Text;
                            secretario.Apellido = TXB_surname.Text;
                            secretario.FechaNacimiento = Convert.ToDateTime(TXB_borndate.Text);
                            secretario.Email = TXB_email.Text;
                            secretario.Legajo = int.Parse(TXB_legajo.Text);
                            secretario.Telefono = int.Parse(TXB_phone.Text);
                            secretario.HorarioEntrada = Convert.ToDateTime(TXB_horarioentrada.Text);
                            secretario.HorarioSalida = Convert.ToDateTime(TXB_horariosalida.Text);
                            n_Secretario.CheakAndSaved(secretario);
                            Nuser.CheckAndSave(user);
                        }
                        else
                        {
                            throw new Exception("No debe dejar ningun campo vacio");
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Debe marcar como checkeado una sola");
            }
        }

        private void LL_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }
    }
}

