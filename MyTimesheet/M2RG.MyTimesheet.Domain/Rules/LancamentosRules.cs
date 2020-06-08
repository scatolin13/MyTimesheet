using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Lancamentos : EntityBase
    {
        public Lancamentos()
        {
            Id = 0;
        }

        public Lancamentos(int id)
        {
            IsGreaterThan(id, 0, EntityName, "ID", "deve ser maior que zero");

            if (IsValid)
                Id = id;
        }

        public Lancamentos Adicionar(int agendaId, DateTime horario, bool entrada)
        {
            IsGreaterThan(agendaId, 0, EntityName, "Agenda ID", "deve ser maior que zero");
            IsLowerOrEqualsThan(horario, EntityName, DateTime.Now, "Horário", "não é permitido datas futuras");

            if (IsValid)
            {
                EscalaId = agendaId;
                Horario = horario;
                Entrada = entrada;
            }

            return this;
        }

    }
}
