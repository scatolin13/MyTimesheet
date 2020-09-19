using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class Usuarios : EntityBase
    {
        public Usuarios(int id)
        {
            if (IsValid)
                Id = id;
        }

        public Usuarios Adicionar(string nome, string cpf, string rg, string email, string login, string senha)
        {
            IsNotNullOrWhiteSpace(nome, EntityName, "Nome", "não pode ser vazio");
            IsCPF(cpf, EntityName, "CPF", "inválido");
            IsNotNullOrWhiteSpace(login, EntityName, "Login", "não pode ser vazio");

            AlterarSenha(senha);
            AlterarEmail(email);

            if (IsValid)
            {
                Nome = nome;
                Cpf = cpf;
                Rg = rg;
                Login = login;
                Ativar();
                DataCadastro = DateTime.Now;
            }

            return this;
        }

        public Usuarios Alterar(string nome, string cpf, string rg)
        {
            IsGreaterThan(Id, 0, EntityName, "ID", "deve ser maior que zero");
            IsNotNullOrWhiteSpace(nome, EntityName, "Nome", "não pode ser vazio");
            IsCPF(cpf, EntityName, "CPF", "inválido");

            if (IsValid)
            {
                Nome = nome;
                Cpf = cpf;
                Rg = rg;
            }

            return this;
        }

        public Usuarios AlterarSenha(string senha)
        {
            IsPassword(senha, EntityName, "Senha", "deve conter no mínimo 8 caracteres, pelo menos 1 letra maiúscula e 1 minúscula, 1 números e 1 caracter especial");

            if (IsValid)
                Senha = senha;

            return this;
        }

        public Usuarios AlterarEmail(string email)
        {
            IsEmail(email, EntityName, "E-Mail", "inválido");

            if (IsValid)
                Email = email;

            return this;
        }

        public Usuarios AtualizarUltimoAcesso()
        {
            PenultimoAcesso = UltimoAcesso;
            UltimoAcesso = DateTime.Now;

            return this;
        }

        public Usuarios Ativar()
        {
            EstaAtivo = true;

            return this;
        }

        public Usuarios Desativar()
        {
            EstaAtivo = false;

            return this;
        }

        public Usuarios AumentarTentativa()
        {
            Tentativas++;

            return this;
        }

        public Usuarios ZerarTentativas()
        {
            Tentativas = 0;

            return this;
        }

        public Usuarios ValidarUsuario()
        {
            IsFalse(EstaAtivo, EntityName, "Usuario", "está inativado");
            IsLowerOrEqualsThan(Tentativas, 3, EntityName, "Tentativas", "número excedido");
            IsNotNull(DataExclusao, EntityName, "Usuário", "inválido");

            return this;
        }

    }
}
