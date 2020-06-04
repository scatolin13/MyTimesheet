using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Usuarios
    {
        public int Id { get; private set; }
        public int EmpresaId { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Email { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? UltimoAcesso { get; private set; }
        public byte EstaAtivo { get; private set; }
        public int Tentativas { get; private set; }
        public DateTime? DataExclusao { get; private set; }
    }
}
