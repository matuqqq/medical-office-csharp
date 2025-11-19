using CapaDatos;
using CapaDatos.Clases.Datos;
using CapaDatos.Clases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class N_Especialidad
    {

        public bool CheckAndSave(E_especialidad especialidad)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(especialidad.NombreEspecialidad))
                    throw new Exception("El nombre de la especialidad no puede estar vacío.");

                var d_Especialidad = new D_Especialidad();
                var espe = new Especialidad
                {
                    NombreEspecialidad = especialidad.NombreEspecialidad.Trim()
                };

                bool resultado = d_Especialidad.Save(espe);

                if (!resultado)
                    throw new Exception("La especialidad ya existe.");

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar la especialidad: {ex.Message}");
            }
        }
    }
}
