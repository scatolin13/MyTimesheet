using System;
using System.Text.RegularExpressions;

namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase
    {
        public EntityBase IsNotNullOrEmpty(string val, string key, string property, string message)
        {
            if (string.IsNullOrEmpty(val))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsNotNullOrWhiteSpace(string val, string key, string property, string message)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                AddNotification(key, property, message);
            }

            return this;
        }


        public EntityBase IsNullOrEmpty(string val, string key, string property, string message)
        {
            if (!string.IsNullOrEmpty(val))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase HasMinLen(string val, int min, string key, string property, string message)
        {
            if (string.IsNullOrEmpty(val) || val.Length < min)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase HasMaxLen(string val, int max, string key, string property, string message)
        {
            if (string.IsNullOrEmpty(val) || val.Length > max)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase HasLen(string val, int len, string key, string property, string message)
        {
            if (string.IsNullOrEmpty(val) || val.Length != len)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase Contains(string val, string text, string key, string property, string message)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (!val.Contains(text))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(string val, string text, string key, string property, string message, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            if (!val.Equals(text, comparisonType))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(string val, string text, string key, string property, string message, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            if (val.Equals(text, comparisonType))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsEmail(string email, string key, string property, string message)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            return Matchs(email, pattern, key, property, message);
        }

        public EntityBase IsCPF(string cpf, string key, string property, string message)
        {
            bool valid = true;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                valid = false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    valid = false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            if (valid)
            {
                valid = cpf.EndsWith(digito);
            }

            if (!valid)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsCNPJ(string cnpj, string key, string property, string message)
        {
            bool valid = true;
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                valid = false;

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            if (valid)
            {
                valid = cnpj.EndsWith(digito);
            }

            if (!valid)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsEmailOrEmpty(string email, string key, string property, string message)
        {
            if (string.IsNullOrEmpty(email))
            {
                return this;
            }

            return IsEmail(email, key, property, message);
        }

        public EntityBase IsUrl(string url, string key, string property, string message)
        {
            const string pattern = @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";

            return Matchs(url, key, pattern, property, message);
        }

        public EntityBase IsUrlOrEmpty(string url, string key, string property, string message)
        {
            if (string.IsNullOrEmpty(url))
            {
                return this;
            }

            return IsUrl(url, key, property, message);
        }

        public EntityBase Matchs(string text, string pattern, string key, string property, string message)
        {
            if (!Regex.IsMatch(text ?? "", pattern))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsDigit(string text, string key, string property, string message)
        {
            const string pattern = @"^\d+$";

            return Matchs(text, pattern, key, property, message);
        }

        public EntityBase HasMinLengthIfNotNullOrEmpty(string text, int min, string key, string property, string message)
        {
            if (!string.IsNullOrEmpty(text) && text.Length < min)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase HasMaxLengthIfNotNullOrEmpty(string text, int max, string key, string property, string message)
        {
            if (!string.IsNullOrEmpty(text) && text.Length > max)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase HasExactLengthIfNotNullOrEmpty(string text, int len, string key, string property, string message)
        {
            if (!string.IsNullOrEmpty(text) && text.Length != len)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
    }
}
