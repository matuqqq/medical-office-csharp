using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Datos
{
    public class D_secretario
    {

        public bool Save(Secretario s)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                if (db.PersonaSet.Any(p => p.DNI == s.DNI))
                    return false;

                if (db.PersonaSet.OfType<Secretario>().Any(sec => sec.Legajo == s.Legajo))
                    return false;

                db.PersonaSet.Add(s);
                db.SaveChanges();
                return true;
            }
        }

        public Secretario GetByDNI(int dni)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                return db.PersonaSet.OfType<Secretario>().FirstOrDefault(s => s.DNI == dni);
            }
        }

        public bool DeleteByDNI(int dni)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var secretario = db.PersonaSet.OfType<Secretario>().FirstOrDefault(s => s.DNI == dni);
                if (secretario == null) return false;

                db.PersonaSet.Remove(secretario);
                db.SaveChanges();
                return true;
            }
        }

        public bool Update(Secretario s)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                var secretarioExistente = db.PersonaSet.OfType<Secretario>().FirstOrDefault(x => x.DNI == s.DNI);
                if (secretarioExistente == null) return false;

                secretarioExistente.Nombre = s.Nombre;
                secretarioExistente.Apellido = s.Apellido;
                secretarioExistente.Email = s.Email;
                secretarioExistente.Legajo = s.Legajo;
                secretarioExistente.Telefono = s.Telefono;
                secretarioExistente.HorarioEntrada = s.HorarioEntrada;
                secretarioExistente.HorarioSalida = s.HorarioSalida;
                secretarioExistente.FechaNacimiento = s.FechaNacimiento;

                db.SaveChanges();
                return true;
            }
        }
    }
}