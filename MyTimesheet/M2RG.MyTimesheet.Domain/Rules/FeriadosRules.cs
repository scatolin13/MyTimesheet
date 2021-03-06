﻿using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Feriados : EntityBase
    {
        public Feriados(int id)
        {

            if (IsValid)
                Id = id;
        }

        public Feriados Adicionar(DateTime data, string descricao, bool feriadoFixo, bool feriadoNacional)
        {
            IsNotNullOrWhiteSpace(descricao, EntityName, "Descrição", "não pode ser vazio");

            if (IsValid)
            {
                Data = data;
                Descricao = descricao;
                FeriadoFixo = feriadoFixo;
                FeriadoNacional = feriadoNacional;
            }

            return this;
        }

        public Feriados Alterar(DateTime data, string descricao, bool feriadoFixo, bool feriadoNacional)
        {
            IsGreaterThan(Id, 0, EntityName, "ID", "deve ser maior que zero");

            Adicionar(data, descricao, feriadoFixo, feriadoNacional);

            return this;
        }

        public Feriados VincularEmpresa(int empresaId)
        {
            IsGreaterThan(empresaId, 0, EntityName, "Empresa ID", "deve ser maior que zero");

            if (IsValid)
                EmpresaId = empresaId;

            return this;
        }

    }
}
