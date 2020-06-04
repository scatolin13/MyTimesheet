using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Agendas
    {
        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public int EmpresaId { get; private set; }
        public int UsuarioId { get; private set; }
        public DateTime? DataExclusao { get; private set; }
        public int? FeriadoId { get; private set; }
        public string Descricao { get; private set; }
    }
}
