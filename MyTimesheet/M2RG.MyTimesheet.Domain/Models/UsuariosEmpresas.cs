using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class UsuariosEmpresas
    {
        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public int EmpresaId { get; private set; }
        public DateTime DataAceite { get; private set; }

        public virtual Empresas Empresa { get; private set; }
        public virtual Usuarios Usuario { get; private set; }
    }
}
