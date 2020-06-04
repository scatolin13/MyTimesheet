namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Parametros
    {
        public int Id { get; private set; }
        public int EmpresaId { get; private set; }
        public int? UsuarioId { get; private set; }
        public decimal CargaHorariaDia { get; private set; }
        public decimal? MediaMensalHora { get; private set; }
        public bool UsarFixoMensal { get; private set; }
    }
}
