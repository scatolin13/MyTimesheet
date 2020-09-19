using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Lancamentos : EntityBase
    {
        public Lancamentos(int id)
        {
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

        public Lancamentos Alterar(int agendaId, DateTime horario, bool entrada)
        {
            IsGreaterThan(Id, 0, EntityName, "ID", "deve ser maior que zero");

            Adicionar(agendaId, horario, entrada);

            return this;
        }
    }
}
