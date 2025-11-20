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
    public class N_Turno
    {
        private readonly D_turno dTurno = new D_turno();

        public E_turno GetTurnoById(int id)
        {
            if (id <= 0) return null;
            return dTurno.GetById(id);
        }

        public bool CheckAndSave(E_turno t)
        {
            try
            {
                if (t == null)
                    throw new Exception("No se recibió información del turno.");

                if (t.MedicoId <= 0)
                    throw new Exception("El ID del médico no es válido.");

                if (t.PacienteId <= 0)
                    throw new Exception("El ID del paciente no es válido.");

                if (t.Fecha == DateTime.MinValue)
                    throw new Exception("La fecha del turno no es válida.");

                if (string.IsNullOrWhiteSpace(t.Hora))
                    throw new Exception("La hora del turno es obligatoria.");
                var turno = new Turno
                {
                    Fecha = t.Fecha,
                    Hora = t.Hora,
                    Estado = t.Estado,
                    PacienteId = t.PacienteId,
                    MedicoId = t.MedicoId
                };
                return dTurno.Save(turno);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el turno: " + ex.Message);
            }
        }

        public bool UpdateTurno(E_turno t)
        {
            if (t == null) return false;
            if (t.MedicoId == 0 || t.Estado < 0) return false;

            var Uturno = new Turno();
            {
                Uturno.Id = t.Id;
                Uturno.Fecha = t.Fecha;
                Uturno.Hora = t.Hora;
                Uturno.Estado = t.Estado;
                Uturno.PacienteId = t.PacienteId;
                Uturno.MedicoId = t.MedicoId;
            }

            return dTurno.Update(Uturno);
        }
    }
}
