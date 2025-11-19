using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Datos
{
    public class D_usuario
    {

        public void Save(Usuario u)
        {
            using (ApplicationDBContextContainer db = new ApplicationDBContextContainer())
            {
                db.UsuarioSet.Add(u);
                db.SaveChanges();
            }
        }
    }
}
