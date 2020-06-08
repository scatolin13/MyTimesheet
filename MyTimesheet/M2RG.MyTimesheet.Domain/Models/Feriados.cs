using System;
using System.Collections.Generic;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Feriados
    {
        public Feriados()
        {
            Escalas = new HashSet<Escalas>();
        }

        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }
        public bool FeriadoFixo { get; private set; }
        public bool FeriadoNacional { get; private set; }
        public int? EmpresaId { get; private set; }

        public virtual Empresas Empresa { get; private set; }
        public virtual ICollection<Escalas> Escalas { get; private set; }
    }
}
