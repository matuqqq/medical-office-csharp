using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Entity;

namespace CapaDatos.Clases.Datos
{
    public class D_medico
    {
        public bool Save(Medico m)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                if (db.PersonaSet.Any(p => p.DNI == m.DNI))
                    return false; // ya existe

                db.PersonaSet.Add(m);
                db.SaveChanges();
                return true;
            }
        }
    }
}

