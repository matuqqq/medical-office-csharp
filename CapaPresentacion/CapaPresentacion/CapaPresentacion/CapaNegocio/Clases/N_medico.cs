using CapaDatos.Clases.Datos;
using CapaDatos.Clases.Entities;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class N_medico
    {
        D_medico d_Medico = new D_medico();

        public void CheckAndSave(E_medico m)
        {
            if (m == null) return;
            if ((m.Telefono == 0) || (m.Id == 0) || (m.Legajo == 0) || (m.DNI == 0))
            {
                return;
            }
            Medico med = new Medico();
            med.Nombre = m.Nombre;
            med.Id = m.Id;
            med.DNI = m.DNI;
            med.Legajo = m.Legajo;
            med.Matricula = m.Matricula;
            med.Apellido = m.Apellido;
            med.Email = m.Email;
            med.FechaNacimiento = m.FechaNacimiento;
            d_Medico.Save(med);
        }
    }
}
