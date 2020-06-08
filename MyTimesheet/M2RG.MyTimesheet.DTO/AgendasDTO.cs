using M2RG.MyTimesheet.Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace M2RG.MyTimesheet.DTO
{
    public class AgendasDTO : EntityBase
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int EmpresaId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime? DataExclusao { get; set; }
        public int? FeriadoId { get; set; }
        public string Descricao { get; set; }
    }
}
