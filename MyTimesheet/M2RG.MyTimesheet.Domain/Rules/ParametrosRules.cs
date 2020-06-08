using M2RG.MyTimesheet.Flunt.Validations;
using System;

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
            IsGreaterThan(id, 0, EntityName, "ID", "deve ser maior que zero");

            if (IsValid)
                Id = id;
        }

        public Parametros Adicionar(int empresaId, TimeSpan cargaHorariaDia, bool considerarSegunda, bool considerarTerca, bool considerarQuarta,
                bool considerarQuinta, bool considerarSexta, bool considerarSabado, bool considerarDomingo)
        {
            IsGreaterThan(empresaId, 0, EntityName, "Empresa ID", "deve ser maior que zero");
            
            if (IsValid)
            {
                EmpresaId = empresaId;
                CargaHorariaDia = cargaHorariaDia;
                ConsiderarSegunda = considerarSegunda;
                ConsiderarTerca = considerarTerca;
                ConsiderarQuarta = considerarQuarta;
                ConsiderarQuinta = considerarQuinta;
                ConsiderarSexta = considerarSexta;
                ConsiderarSabado = considerarSabado;
                ConsiderarDomingo = considerarDomingo;
            }

            return this;
        }

    }
}
