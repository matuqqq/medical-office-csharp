using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Datos
{
    public class D_secretario
    {

        public void Save(Secretario s)
        {
            ApplicationDBContextContainer db = new ApplicationDBContextContainer();
            db.PersonaSet.Add(s);
            db.SaveChanges();
        }
    }
}
