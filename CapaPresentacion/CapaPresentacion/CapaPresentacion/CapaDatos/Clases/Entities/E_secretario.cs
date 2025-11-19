using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Entities
{
    public class E_secretario : E_personal
    {
        public System.DateTime HorarioEntrada { get; set; }
        public System.DateTime HorarioSalida { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
