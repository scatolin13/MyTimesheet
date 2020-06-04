using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Agendas : EntityBase
    {
        public Agendas()
        {
            Id = 0;
        }

        public Agendas(int id)
        {
            IsGreaterOrEqualsThan(id, 0, EntityName, "ID", "deve ser maior que zero");

            if (IsValid)
            {
                Id = id;
            }
        }

        public Agendas Adicionar(DateTime data, int empresaId, int usuarioId, string descricao)
        {

            IsBetween(data.Date, EntityName, DateTime.Now.AddMonths(-1).Date, DateTime.Now.AddMonths(1).Date, "Data", "deve ser do mês atual");
            IsGreaterOrEqualsThan(empresaId, 0, EntityName, "Empresa ID", "deve ser maior que zero");
            IsGreaterOrEqualsThan(usuarioId, 0, EntityName, "Usuário ID", "deve ser maior que zero");
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

        public Agendas AdicionarFeriado(int feriadoId)
        {
            IsGreaterOrEqualsThan(feriadoId, 0, EntityName, "Feriado ID", "deve ser maior que zero");

            if (IsValid)
            {
                FeriadoId = feriadoId;
            }

            return this;
        }

        public void Excluir()
        {
            DataExclusao = DateTime.Now;
        }
    }
}
