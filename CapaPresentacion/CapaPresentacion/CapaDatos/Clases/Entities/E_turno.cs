using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Entities
{
    public class E_turno
    {
        public E_turno()
        {
            this.Consulta = new HashSet<Consulta>();
        }

        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int Estado { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Medico Medico { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
