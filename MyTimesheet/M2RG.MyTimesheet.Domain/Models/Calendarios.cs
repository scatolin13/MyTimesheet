using System;
using System.Collections.Generic;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Calendarios
    {
        public Calendarios()
        {
            Escalas = new HashSet<Escalas>();
        }

        public int Id { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public int UsuarioId { get; private set; }
        public int EmpresaId { get; private set; }
        public int ParametroId { get; private set; }

        public virtual Empresas Empresa { get; private set; }
        public virtual Parametros Parametro { get; private set; }
        public virtual ICollection<Escalas> Escalas { get; private set; }
    }
}
