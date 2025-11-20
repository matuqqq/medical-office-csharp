using CapaDatos.Clases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Datos
{
    public class D_Especialidad
    {

        public bool Save(Especialidad e)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                if (db.EspecialidadSet.Any(es => es.NombreEspecialidad == e.NombreEspecialidad))
                    return false;

                var nuevaEspecialidad = new Especialidad
                {
                    NombreEspecialidad = e.NombreEspecialidad
                };

                db.EspecialidadSet.Add(nuevaEspecialidad);
                db.SaveChanges();
                return true;
            }
        }

        public List<Especialidad> GetAllEspecialidades()
        {
            using (var db = new ApplicationDBContextContainer())
            {
                return db.EspecialidadSet.ToList();
            }
        }
    }
}
