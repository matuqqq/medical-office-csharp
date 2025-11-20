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
            var usr = new Usuario() 
            {    
                NombreUsuario = u.NombreUsuario,
                Id = u.Id,
                Rol = u.Rol,
                PasswordHash = u.PasswordHash
            };
                duser.Save(usr);
            }
        }
}
