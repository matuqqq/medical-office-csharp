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
    public class N_HistorialMedico
    {
        D_HistorialMedico d_HistorialMedico = new D_HistorialMedico();
        public bool CheckAndSave(E_historiaClinica e)
        {
            if (e == null) return false;
            if (!DateTime.TryParse(e.FechaCreacion.ToString(), out DateTime fecha))
            {
                return false;
            }

            var historialMedico = new HistoriaClinica
            {
                FechaCreacion = fecha,
            };

            try
            {
                return d_HistorialMedico.Save(historialMedico);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el historial medico: " + ex.ToString());
            }
        }
    }
}
