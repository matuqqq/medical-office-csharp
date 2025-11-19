using CapaDatos.Clases.Entities;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Clases.Datos;

namespace CapaNegocio.Clases
{
    public class N_secretario
    {      
            D_secretario Dsecretario = new D_secretario();
            public void CheckAndSaved(E_secretario s)
            {

                if (s == null) return;
                if ((s.Telefono == 0) || (s.Id == 0) || (s.Legajo == 0) || (s.DNI == 0))
                {
                    return;
                }
                Secretario se = new Secretario();
                se.Nombre = s.Nombre;
                se.Id = s.Id;
                se.DNI = s.DNI;
                se.Legajo = s.Legajo;
                se.HorarioEntrada = s.HorarioEntrada;
                se.HorarioSalida = s.HorarioSalida;
                se.Apellido = s.Apellido;
                se.Email = s.Email;
                se.FechaNacimiento = s.FechaNacimiento;
                Dsecretario.Save(se);
            
        }
    }
}
