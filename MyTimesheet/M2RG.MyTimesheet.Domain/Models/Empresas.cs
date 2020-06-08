using System;
using System.Collections.Generic;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Empresas
    {
        public Empresas()
        {
            Calendarios = new HashSet<Calendarios>();
            Escalas = new HashSet<Escalas>();
            Feriados = new HashSet<Feriados>();
            Parametros = new HashSet<Parametros>();
            UsuariosEmpresas = new HashSet<UsuariosEmpresas>();
        }

        public int Id { get; private set; }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Cnpj { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool EstaAtivo { get; private set; }
        public int CriadoPor { get; private set; }
        public DateTime? DataExclusao { get; private set; }

        public virtual ICollection<Calendarios> Calendarios { get; private set; }
        public virtual ICollection<Escalas> Escalas { get; private set; }
        public virtual ICollection<Feriados> Feriados { get; private set; }
        public virtual ICollection<Parametros> Parametros { get; private set; }
        public virtual ICollection<UsuariosEmpresas> UsuariosEmpresas { get; private set; }
    }
}
