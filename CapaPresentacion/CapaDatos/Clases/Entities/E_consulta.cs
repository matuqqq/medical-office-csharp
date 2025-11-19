using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Entities
{
    public class E_consulta
    {
        public int Id { get; set; }
        public int HistoriaClinicaId { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public int TurnoId { get; set; }

        public virtual HistoriaClinica HistoriaClinica { get; set; }
        public virtual Turno Turno { get; set; }
    }
}
