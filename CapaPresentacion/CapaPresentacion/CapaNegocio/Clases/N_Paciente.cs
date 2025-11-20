using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.Entities;
using CapaDatos.Clases.Datos;
using CapaDatos;

namespace CapaNegocio.Clases
{
    public class N_Paciente
    {
        D_Paciente d_Paciente = new D_Paciente();
        public bool CheckAndSave(E_paciente p)
        {
            try
            {
                if (p == null)
                    throw new Exception("No se recibió información del paciente.");
                if (p.DNI <= 0)
                    throw new Exception("El DNI debe ser mayor a cero.");
                if (string.IsNullOrWhiteSpace(p.Nombre) || string.IsNullOrWhiteSpace(p.Apellido))
                    throw new Exception("El nombre y el apellido son obligatorios.");

                var paciente = new Paciente();
                {
                    paciente.DNI = p.DNI;
                    paciente.Nombre = p.Nombre;
                    paciente.Apellido = p.Apellido;
                    paciente.FechaNacimiento = p.FechaNacimiento;
                    paciente.ObraSocial = p.ObraSocial;
                    paciente.NumeroAfiliado = p.NumeroAfiliado;

                }

                return d_Paciente.Save(paciente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el paciente: {ex.Message}");
            }
        }

        public bool UpdatePaciente(E_paciente p)
        {
            try
            {
                if (p == null)
                    throw new Exception("No se recibió información del paciente.");
                if (p.DNI <= 0)
                    throw new Exception("El DNI debe ser mayor a cero.");
                if (string.IsNullOrWhiteSpace(p.Nombre) || string.IsNullOrWhiteSpace(p.Apellido))
                    throw new Exception("El nombre y el apellido son obligatorios.");

                var paciente = new Paciente();
                {
                    paciente.DNI = p.DNI;
                    paciente.Nombre = p.Nombre;
                    paciente.Apellido = p.Apellido;
                    paciente.FechaNacimiento = p.FechaNacimiento;
                    paciente.ObraSocial = p.ObraSocial;
                    paciente.NumeroAfiliado = p.NumeroAfiliado;
                }

                return d_Paciente.Update(paciente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el paciente: {ex.Message}");
            }
        }

        public bool EliminarPaciente(int dni)
        {
            try
            {
                if (dni <= 0)
                    throw new Exception("El DNI debe ser mayor a cero.");

                return d_Paciente.Delete(dni);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el paciente: {ex.Message}");
            }
        }
    }
}
