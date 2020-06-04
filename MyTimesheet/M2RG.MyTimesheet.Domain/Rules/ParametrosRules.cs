using M2RG.MyTimesheet.Flunt.Validations;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Parametros : EntityBase
    {
        public Parametros()
        {
            Id = 0;
        }

        public Parametros(int id)
        {
            IsGreaterOrEqualsThan(id, 0, EntityName, "ID", "deve ser maior que zero");

            if (IsValid)
            {
                Id = id;
            }
        }

        public Parametros Adicionar(int empresaId, int? usuarioId, decimal cargaHorariaDia, bool usarFixoMensal, decimal? mediaMensalHora)
        {
            IsGreaterOrEqualsThan(empresaId, 0, EntityName, "Empresa ID", "deve ser maior que zero");
            IfNotNull(usuarioId, o => IsGreaterOrEqualsThan(usuarioId.Value, 0, EntityName, "Usuário ID", "deve ser maior que zero"));
            IsGreaterOrEqualsThan(cargaHorariaDia, 0, EntityName, "Carga horária dia", "deve ser maior que zero");

            if (usarFixoMensal)
            {
                IsGreaterOrEqualsThan(mediaMensalHora.Value, 0, EntityName, "Média de horas mensal", "deve ser maior que zero");
            }

            if (IsValid)
            {
                EmpresaId = empresaId;
                UsuarioId = usuarioId;
                CargaHorariaDia = cargaHorariaDia;
                UsarFixoMensal = usarFixoMensal;
                MediaMensalHora = mediaMensalHora;
            }

            return this;
        }

    }
}
