using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Empresas : EntityBase
    {
        public Empresas(int id)
        {
            if (IsValid)
                Id = id;
        }

        public Empresas Adicionar(string razaoSocial, string nomeFantasia, string cnpj, string email, int criadoPor)
        {
            IsNotNullOrWhiteSpace(razaoSocial, EntityName, "Razão social", "não pode ser vazio");
            IsNotNullOrWhiteSpace(nomeFantasia, EntityName, "Nome fantasia", "não pode ser vazio");
            IsCNPJ(cnpj, EntityName, "CNPJ", "inválido");
            IsEmail(email, EntityName, "E-mail", "formato inválido");

            if (IsValid)
            {
                RazaoSocial = razaoSocial;
                NomeFantasia = nomeFantasia;
                Cnpj = cnpj;
                Email = email;
                CriadoPor = criadoPor;
                DataCadastro = DateTime.Now;
                Ativar();
            }

            return this;
        }

        public Empresas Alterar(string razaoSocial, string nomeFantasia, string cnpj, string email)
        {
            IsGreaterThan(Id, 0, EntityName, "ID", "deve ser maior que zero");
            IsNotNullOrWhiteSpace(razaoSocial, EntityName, "Razão social", "não pode ser vazio");
            IsNotNullOrWhiteSpace(nomeFantasia, EntityName, "Nome fantasia", "não pode ser vazio");
            IsCNPJ(cnpj, EntityName, "CNPJ", "inválido");
            IsEmail(email, EntityName, "E-mail", "formato inválido");

            if (IsValid)
            {
                RazaoSocial = razaoSocial;
                NomeFantasia = nomeFantasia;
                Cnpj = cnpj;
                Email = email;
                EstaAtivo = true;
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
