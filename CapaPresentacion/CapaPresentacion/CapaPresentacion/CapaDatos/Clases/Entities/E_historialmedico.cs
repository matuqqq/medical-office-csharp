using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Entities
{
    public class E_historiaClinica
    {
        public E_historiaClinica()
        {
            this.Consulta = new HashSet<Consulta>();
            this.Paciente = new HashSet<Paciente>();
        }

        public int Id { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual ICollection<Paciente> Paciente { get; set; }
    }
}
