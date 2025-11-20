using CapaDatos;
using CapaDatos.Clases.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Datos
{
    public class D_medico
    {
        public bool Save(Medico m, Usuario u)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                if (db.PersonaSet.Any(p => p.DNI == m.DNI))
                    return false;

                db.UsuarioSet.Add(u);
                db.SaveChanges();

                m.UsuarioSets = new List<Usuario> { u };

                db.PersonaSet.Add(m);
                db.SaveChanges();

                return true;
            }
        }
        

        public bool ExecuteSQLCommand(Medico med, Usuario usuario)
        {
            using (var db = new ApplicationDBContextContainer())
            {
                db.Database.ExecuteSqlCommand(
            "INSERT INTO PersonaSet_Medico (Nombre, Apellido, DNI, Legajo, Matricula, Email, FechaNacimiento, Telefono, EspecialidadId, Usuario_Id) " +
            "VALUES (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",
             med.Nombre, med.Apellido, med.DNI, med.Legajo, med.Matricula, med.Email, med.FechaNacimiento, med.Telefono, med.EspecialidadId, usuario.Id
             );
                return true;
            }
        }
    }
}

