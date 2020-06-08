using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Escalas : EntityBase
    {
        public Escalas()
        {
            Id = 0;
        }

        public Escalas(int id)
        {
            IsGreaterThan(id, 0, EntityName, "ID", "deve ser maior que zero");

            if (IsValid)
                Id = id;
        }

        public Escalas Adicionar(DateTime data, int empresaId, int usuarioId, string descricao)
        {

            IsBetween(data.Date, EntityName, DateTime.Now.AddMonths(-1).Date, DateTime.Now.AddMonths(1).Date, "Data", "deve ser do mês atual");
            IsGreaterThan(empresaId, 0, EntityName, "Empresa ID", "deve ser maior que zero");
            IsGreaterThan(usuarioId, 0, EntityName, "Usuário ID", "deve ser maior que zero");
            IsNotNullOrWhiteSpace(descricao, EntityName, "Descrição", "não pode ser vazio");

            if (IsValid)
            {
                Data = data;
                EmpresaId = empresaId;
                UsuarioId = usuarioId;
                Descricao = descricao;
            }

            return this;
        }

        public Escalas AdicionarFeriado(int feriadoId)
        {
            IsGreaterThan(feriadoId, 0, EntityName, "Feriado ID", "deve ser maior que zero");

            if (IsValid)
                FeriadoId = feriadoId;

            return this;
        }

        public void Excluir()
        {
            DataExclusao = DateTime.Now;
        }
    }
}
