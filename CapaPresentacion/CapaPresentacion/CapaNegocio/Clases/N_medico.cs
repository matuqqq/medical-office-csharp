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
    public class N_medico
    {
        private readonly D_medico d_Medico = new D_medico();
        D_usuario d_Usuario = new D_usuario();

        public bool CheckAndSave(E_medico m)
        {
            if (m == null) return false;
            if ((m.Telefono == 0) || (m.Legajo == 0) || (m.DNI == 0))
                return false;

            var usuario = new Usuario
            {
                NombreUsuario = (m.Nombre + m.Apellido).Trim(),
                PasswordHash = "1234"
            };

            var medico = new Medico
            {
                Nombre = m.Nombre,
                Apellido = m.Apellido,
                DNI = m.DNI,
                Legajo = m.Legajo,
                Matricula = m.Matricula,
                Email = m.Email,
                FechaNacimiento = m.FechaNacimiento,
                Telefono = m.Telefono,
                EspecialidadId = m.EspecialidadId
            };

            try
            {
                return d_Medico.Save(medico, usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el médico: " + ex.ToString());
            }
        }
    }
}