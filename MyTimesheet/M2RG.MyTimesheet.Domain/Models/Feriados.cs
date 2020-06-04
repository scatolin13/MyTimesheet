using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Feriados
    {
        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }
        public bool FeriadoFixo { get; private set; }
        public bool FeriadoNacional { get; private set; }
        public int? EmpresaId { get; private set; }
    }
}
