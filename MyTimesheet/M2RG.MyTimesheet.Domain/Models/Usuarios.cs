using System;
using System.Collections.Generic;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Escalas = new HashSet<Escalas>();
            UsuariosEmpresas = new HashSet<UsuariosEmpresas>();
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Email { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? UltimoAcesso { get; private set; }
        public DateTime? PenultimoAcesso { get; private set; }

        public bool EstaAtivo { get; private set; }
        public int Tentativas { get; private set; }
        public int PerfilId { get; private set; }
        public DateTime? DataExclusao { get; private set; }

        public virtual Perfis Perfil { get; private set; }
        public virtual ICollection<Escalas> Escalas { get; private set; }
        public virtual ICollection<UsuariosEmpresas> UsuariosEmpresas { get; private set; }
    }
}
