using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Calendarios : EntityBase
    {
        public Calendarios()
        {
            Id = 0;
        }

        public Calendarios(int id)
        {
            IsGreaterThan(id, 0, EntityName, "ID", "deve ser maior que zero");

            if (IsValid)
                Id = id;
        }

        public Calendarios Adicionar(DateTime dataInicio, DateTime dataFim, int usuarioId, int empresaId, int parametroId)
        {
            IsGreaterOrEqualsThan(dataInicio, EntityName, DateTime.Now.AddYears(-1), "Data início", "não pode ser inferior a um ano");
            IsGreaterThan(dataInicio, EntityName, dataFim, "Data fim", "deve ser superior a data início");
            IsLowerThan(dataFim, EntityName, dataInicio.AddDays(31), "Data fim", "deve ter no máximo 31 dias");
            IsGreaterThan(usuarioId, 0, EntityName, "Usuário ID", "deve ser maior que zero");
            IsGreaterThan(empresaId, 0, EntityName, "Empresa ID", "deve ser maior que zero");
            IsGreaterThan(parametroId, 0, EntityName, "Parâmetro ID", "deve ser maior que zero");

            if (IsValid)
            {
                DataInicio = dataInicio;
                DataFim = dataFim;
                UsuarioId = usuarioId;
                EmpresaId = empresaId;
                ParametroId = parametroId;
            }

            return this;
        }
    }
}
