using CapaDatos.Clases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaDatos.Clases.Datos
{
    public class D_turno
    {
        public E_turno GetById(int id)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var t = db.TurnoSet.FirstOrDefault(x => x.Id == id);
                if (t == null) return null;

                return new E_turno
                {
                    Id = t.Id,
                    Fecha = t.Fecha,
                    Hora = t.Hora,
                    Estado = t.Estado,
                    PacienteId = t.PacienteId,
                    MedicoId = t.MedicoId
                };
            }
        }


        public bool Update(Turno turno)
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

        public bool Save(Turno turno)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var medico = db.PersonaSet.OfType<Medico>().FirstOrDefault(x => x.Id == turno.MedicoId);
                if (medico == null)
                    throw new Exception("El médico no existe");

                turno.Medico = medico;

                db.TurnoSet.Add(turno);
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
