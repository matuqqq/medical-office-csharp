using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Datos
{
    public class D_Paciente
    {
        public bool Save(Paciente p)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                if (db.PersonaSet.Any(persona => persona.DNI == p.DNI))
                    return false;
                db.PersonaSet.Add(p);
                db.SaveChanges();
                return true;
            }
        }

        public Paciente GetByDNI(int dni)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                return db.PersonaSet.OfType<Paciente>().FirstOrDefault(p => p.DNI == dni);
            }
        }

        public bool Update(Paciente p)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var existente = db.PersonaSet.OfType<Paciente>().FirstOrDefault(pa => pa.Id == p.Id);
                if (existente == null) return false;
                existente.Nombre = p.Nombre;
                existente.Apellido = p.Apellido;
                existente.DNI = p.DNI;
                existente.FechaNacimiento = p.FechaNacimiento;
                existente.ObraSocial = p.ObraSocial;
                existente.NumeroAfiliado = p.NumeroAfiliado;
                db.SaveChanges();
                return true;
            }
        }

        public bool Delete(int dni)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var paciente = db.PersonaSet.OfType<Paciente>().FirstOrDefault(p => p.DNI == dni);
                if (paciente == null) return false;
                db.PersonaSet.Remove(paciente);
                db.SaveChanges();
                return true;
            }
        }
    }
}
