using CapaDatos.Clases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Datos
{
    public class D_turno
    {
        public E_turno GetById(int id)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var turno = db.TurnoSet.FirstOrDefault(t => t.Id == id);
                if (turno == null) return null;

                return new E_turno
                {
                    Id = turno.Id,
                    Fecha = turno.Fecha,
                    Hora = turno.Hora,
                    Estado = turno.Estado,
                    PacienteId = turno.PacienteId,
                    MedicoId = turno.MedicoId
                };
            }
        }

        public bool Update(E_turno turno)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var existente = db.TurnoSet.FirstOrDefault(t => t.Id == turno.Id);
                if (existente == null) return false;

                existente.Fecha = turno.Fecha;
                existente.Hora = turno.Hora;
                existente.Estado = turno.Estado;
                existente.MedicoId = turno.MedicoId;

                db.SaveChanges();
                return true;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var turno = db.TurnoSet.FirstOrDefault(t => t.Id == id);
                if (turno == null) return false;
                db.TurnoSet.Remove(turno);
                db.SaveChanges();
                return true;
            }
        }
    }
}
