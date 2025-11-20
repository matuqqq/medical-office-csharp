using CapaDatos.Clases.Entities;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.Datos;

namespace CapaNegocio.Clases
{
    public class N_secretario
    {
        private readonly D_secretario Dsecretario = new D_secretario();

        public bool CheckAndSave(E_secretario s)
        {
            if (s == null)
                throw new Exception("No se recibió información del secretario.");

            if (s.DNI <= 0 || s.Legajo <= 0)
                throw new Exception("El DNI y el legajo deben ser mayores a cero.");

            if (string.IsNullOrWhiteSpace(s.Nombre) || string.IsNullOrWhiteSpace(s.Apellido))
                throw new Exception("El nombre y el apellido son obligatorios.");

            var usuario = new Usuario
            {
                NombreUsuario = (s.Nombre + s.Apellido).Trim(),
                PasswordHash = "1234"
            };

            var secretario = new Secretario
            {
                Nombre = s.Nombre,
                Apellido = s.Apellido,
                DNI = s.DNI,
                Email = s.Email,
                Legajo = s.Legajo,
                FechaNacimiento = s.FechaNacimiento,
                HorarioEntrada = s.HorarioEntrada,
                HorarioSalida = s.HorarioSalida
            };

            secretario.UsuarioSets = secretario.UsuarioSets ?? new List<Usuario>();
            secretario.UsuarioSets.Add(usuario);

            try
            {
                return Dsecretario.Save(secretario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el secretario: " + ex.Message);
            }
        }

        public bool EliminarSecretario(int dni)
        {
            try
            {
                return Dsecretario.DeleteByDNI(dni);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el secretario: " + ex.Message);
            }
        }

        public bool ActualizarSecretario(E_secretario s)
        {
            try
            {
                var secretario = new Secretario
                {
                    DNI = s.DNI,
                    Nombre = s.Nombre,
                    Apellido = s.Apellido,
                    Email = s.Email,
                    Legajo = s.Legajo,
                    FechaNacimiento = s.FechaNacimiento,
                    HorarioEntrada = s.HorarioEntrada,
                    HorarioSalida = s.HorarioSalida
                };

                return Dsecretario.Update(secretario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el secretario: " + ex.Message);
            }
        }
    }
}
