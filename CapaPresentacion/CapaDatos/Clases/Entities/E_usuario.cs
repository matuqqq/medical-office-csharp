using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases.Entities
{
    public class E_usuario
    {
        public E_usuario()
        {
            this.Permiso = new HashSet<Permiso>();
        }

        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string PasswordHash { get; set; }
        public bool Rol { get; set; }

        public virtual Secretario Secretario { get; set; }
        public virtual Medico Medico { get; set; }
        public virtual ICollection<Permiso> Permiso { get; set; }
    }
}
