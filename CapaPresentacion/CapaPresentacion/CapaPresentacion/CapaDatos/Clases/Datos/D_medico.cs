using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Datos
{
    public class D_medico
    {
        public void Save(Medico m)
        {
            ApplicationDBContextContainer db = new ApplicationDBContextContainer();
            db.PersonaSet.Add(m);
            db.SaveChanges();
        }
    }
}
