using CapaDatos;
using CapaDatos.Clases.Datos;
using CapaDatos.Clases.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class N_Turno
    {
        private readonly D_turno dTurno = new D_turno();

        public E_turno GetTurnoById(int id)
        {
            return dTurno.GetById(id);
        }

        public bool UpdateTurno(E_turno t)
        {
            if (t == null) return false;
            if (t.MedicoId == 0 || t.Estado < 0) return false;

            return dTurno.Update(t);
        }
    }
}
