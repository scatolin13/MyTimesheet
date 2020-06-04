using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class HorariosAgenda : EntityBase
    {
        public HorariosAgenda()
        {
            Id = 0;
        }

        public HorariosAgenda(int id)
        {
            IsGreaterOrEqualsThan(id, 0, EntityName, "ID", "deve ser maior que zero");

            if (IsValid)
            {
                Id = id;
            }
        }

        public HorariosAgenda Adicionar(int agendaId, DateTime horario, bool entrada)
        {
            IsGreaterOrEqualsThan(agendaId, 0, EntityName, "Agenda ID", "deve ser maior que zero");
            IsLowerOrEqualsThan(horario, EntityName, DateTime.Now, "Horário", "não é permitido datas futuras");

            if (IsValid)
            {
                AgendaId = agendaId;
                Horario = horario;
                Entrada = entrada;
            }

            return this;
        }

    }
}
