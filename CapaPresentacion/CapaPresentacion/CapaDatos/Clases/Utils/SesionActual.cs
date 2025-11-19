using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Utils
{
    public class SesionActual
    {
        public static int PersonaId { get; set; }
        public static string NombreCompleto { get; set; }
        public static bool EsMedico { get; set; }
        public static bool EsSecretario { get; set; }
        public static int? MedicoId { get; set; }
        public static int? SecretarioId { get; set; }
    }
}
