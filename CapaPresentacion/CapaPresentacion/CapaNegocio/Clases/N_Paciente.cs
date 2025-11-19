using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.Entities;
using CapaDatos.Clases.Datos;

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
                // Aquí iría la lógica para guardar el paciente en la base de datos
                // Por ejemplo, llamar a un método de una clase de datos (D_Paciente)
                return true; // Retornar true si se guarda correctamente
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
                // Aquí iría la lógica para actualizar el paciente en la base de datos
                // Por ejemplo, llamar a un método de una clase de datos (D_Paciente)
                return true; // Retornar true si se actualiza correctamente
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el paciente: {ex.Message}");
            }
        }

        public bool CargarHistorialClinico(int dni, E_historiaClinica historia)
        {
            try
            {
                if (dni <= 0)
                    throw new Exception("El DNI debe ser mayor a cero.");
                if (historia == null)
                    throw new Exception("No se recibió información del historial clínico.");
                // Aquí iría la lógica para cargar el historial clínico al paciente en la base de datos
                // Por ejemplo, llamar a un método de una clase de datos (D_Paciente)
                return true; // Retornar true si se carga correctamente
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar el historial clínico: {ex.Message}");
            }
        }
        public bool EliminarPaciente(int dni)
        {
            try
            {
                if (dni <= 0)
                    throw new Exception("El DNI debe ser mayor a cero.");
                // Aquí iría la lógica para eliminar el paciente de la base de datos
                // Por ejemplo, llamar a un método de una clase de datos (D_Paciente)
                return true; // Retornar true si se elimina correctamente
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el paciente: {ex.Message}");
            }
        }
    }
}
