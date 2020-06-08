using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Lancamentos
    {
        public int Id { get; private set; }
        public int EscalaId { get; private set; }
        public DateTime Horario { get; private set; }
        public bool Entrada { get; private set; }

        public virtual Escalas Escala { get; private set; }
    }
}
