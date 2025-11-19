using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Entities
{
    public class E_personal : E_persona
    {
        public int Legajo { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
    }
}
