using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Entities
{
    public class E_especialidad
    {
        public E_especialidad()
        {
            this.Medico = new HashSet<Medico>();
        }

        public int Id { get; set; }
        public string NombreEspecialidad { get; set; }
        public virtual ICollection<Medico> Medico { get; set; }
    }
}
