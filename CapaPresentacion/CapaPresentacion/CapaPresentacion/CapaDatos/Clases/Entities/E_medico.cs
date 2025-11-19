using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Entities
{
    public class E_medico : E_personal
    {
        public E_medico()
        {
            this.Turno = new HashSet<Turno>();
        }

        public int EspecialidadId { get; set; }
        public string Matricula { get; set; }

        public virtual Especialidad Especialidad { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Turno> Turno { get; set; }
    }
}
