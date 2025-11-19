using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Datos
{
    public class D_HistorialMedico
    {
        public bool Save(HistoriaClinica historiaClinica)
        {
            using(var context = new ApplicationDBContextContainer())
            {

                context.HistoriaClinicaSet.Add(historiaClinica);
                context.SaveChanges();
            }
            return true;
        }
    }
}
