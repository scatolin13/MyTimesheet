using System.Collections.Generic;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Perfis
    {
        public Perfis()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public byte EhAdministrador { get; private set; }

        public virtual ICollection<Usuarios> Usuarios { get; private set; }
    }
}
