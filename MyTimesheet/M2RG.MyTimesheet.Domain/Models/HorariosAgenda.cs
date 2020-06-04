using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class HorariosAgenda
    {
        public int Id { get; private set; }
        public int AgendaId { get; private set; }
        public DateTime Horario { get; private set; }
        public bool Entrada { get; private set; }
    }
}
