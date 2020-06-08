using System;
using System.Collections.Generic;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Escalas
    {
        public Escalas()
        {
            Lancamentos = new HashSet<Lancamentos>();
        }

        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public int EmpresaId { get; private set; }
        public int UsuarioId { get; private set; }
        public DateTime? DataExclusao { get; private set; }
        public int? FeriadoId { get; private set; }
        public string Descricao { get; private set; }
        public int CalendarioId { get; private set; }

        public virtual Calendarios Calendario { get; private set; }
        public virtual Empresas Empresa { get; private set; }
        public virtual Feriados Feriado { get; private set; }
        public virtual Usuarios Usuario { get; private set; }
        public virtual ICollection<Lancamentos> Lancamentos { get; private set; }
    }
}
