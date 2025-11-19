using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Entities
{
    public class E_permiso
    {
        public int Id { get; set; }
        public string NombrePermiso { get; set; }
        public bool RolAsociado { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
