using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Empresas
    {
        public int Id { get; private set; }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Cnpj { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool EstaAtivo { get; private set; }
        public DateTime? DataExclusao { get; private set; }
    }
}
