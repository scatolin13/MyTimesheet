using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Empresas : EntityBase
    {
        public Empresas()
        {
            Id = 0;
        }

        public Empresas(int id)
        {
            IsGreaterThan(id, 0, EntityName, "ID", "deve ser maior que zero");

            if (IsValid)
                Id = id;
        }

        public Empresas Adicionar(string razaoSocial, string nomeFantasia, string cnpj, string email, int criadoPor = 0)
        {
            IsNotNullOrWhiteSpace(razaoSocial, EntityName, "Razão social", "não pode ser vazio");
            IsNotNullOrWhiteSpace(nomeFantasia, EntityName, "Nome fantasia", "não pode ser vazio");
            IsCNPJ(cnpj, EntityName, "CNPJ", "inválido");
            IsEmail(email, EntityName, "E-mail", "formato inválido");

            if (Id == 0)
                IsGreaterThan(criadoPor, 0, EntityName, "Criado por", "deve ser maior que zero");

            if (IsValid)
            {
                RazaoSocial = razaoSocial;
                NomeFantasia = nomeFantasia;
                Cnpj = cnpj;
                Email = email;
                EstaAtivo = true;

                if (Id == 0)
                {
                    CriadoPor = criadoPor;
                    DataCadastro = DateTime.Now;
                }
            }

            return this;
        }

        public Empresas Ativar()
        {
            EstaAtivo = true;
            return this;
        }

        public Empresas Desativar()
        {
            EstaAtivo = false;
            return this;
        }

        public void Excluir()
        {
            DataExclusao = DateTime.Now;
        }
    }
}
