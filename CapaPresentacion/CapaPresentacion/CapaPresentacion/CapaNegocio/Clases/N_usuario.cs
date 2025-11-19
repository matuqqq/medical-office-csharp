using CapaDatos.Clases.Datos;
using CapaDatos.Clases.Entities;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class N_usuario
    {

            D_usuario duser = new D_usuario();

            public void CheckAndSave(E_usuario u)
            {
                if (u == null) return;
                if ((u.Id == 0) || (u.NombreUsuario == "") || (u.PasswordHash == ""))
                {
                    return;
                }
                Usuario usr = new Usuario();
                usr.NombreUsuario = u.NombreUsuario;
                usr.Id = u.Id;
                usr.Rol = u.Rol;
                usr.PasswordHash = u.PasswordHash;
                duser.Save(usr);
            }
        }
}
