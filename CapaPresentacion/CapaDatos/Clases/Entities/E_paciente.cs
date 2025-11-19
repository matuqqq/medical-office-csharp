using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Entities
{
    public class E_paciente : E_persona
    {
        public E_paciente()
        {
            this.Turno = new HashSet<Turno>();
        }

        public int HistoriaClinicaId { get; set; }
        public string ObraSocial { get; set; }
        public int NumeroAfiliado { get; set; }

        public virtual HistoriaClinica HistoriaClinica { get; set; }
        public virtual ICollection<Turno> Turno { get; set; }
    }
}
