using System;
using System.Collections.Generic;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Parametros
    {
        public Parametros()
        {
            Calendarios = new HashSet<Calendarios>();
        }

        public int Id { get; private set; }
        public int EmpresaId { get; private set; }
        public TimeSpan CargaHorariaDia { get; private set; }
        public bool ConsiderarSegunda { get; private set; }
        public bool ConsiderarTerca { get; private set; }
        public bool ConsiderarQuarta { get; private set; }
        public bool ConsiderarQuinta { get; private set; }
        public bool ConsiderarSexta { get; private set; }
        public bool ConsiderarSabado { get; private set; }
        public bool ConsiderarDomingo { get; private set; }

        public virtual Empresas Empresa { get; private set; }
        public virtual ICollection<Calendarios> Calendarios { get; private set; }
    }
}
