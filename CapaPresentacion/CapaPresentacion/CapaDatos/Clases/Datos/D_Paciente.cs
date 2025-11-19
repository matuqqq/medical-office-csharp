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
                // Verificar que no exista el mismo DNI
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

    }
}
