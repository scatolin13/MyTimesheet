using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace M2RG.MyTimesheet.Encryption
{
    public class Rijndael
    {
        private const string ENCRYPTION_KEY = "MyLongKey_WithSpecialChacter@10293848567";

        private readonly static byte[] SALT = Encoding.ASCII.GetBytes(ENCRYPTION_KEY.Length.ToString());

        public static string Encrypt(string inputText)
        {
            using (PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(ENCRYPTION_KEY, SALT))
            {
                using (RijndaelManaged rijndaelCipher = new RijndaelManaged())
                {
                    using (ICryptoTransform encryptor = rijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16)))
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                byte[] plainText = Encoding.Unicode.GetBytes(inputText);

                                cryptoStream.Write(plainText, 0, plainText.Length);
                                cryptoStream.FlushFinalBlock();

                                return Convert.ToBase64String(memoryStream.ToArray());
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string inputText)
        {
            //Ocorreu com o id 2Dx+fmXobm5Fpk8zz7rSAg==, sinal de + virou espaço
            inputText = inputText.Replace(' ', '+');

            using (PasswordDeriveBytes secretKey = new PasswordDeriveBytes(ENCRYPTION_KEY, SALT))
            {
                using (RijndaelManaged rijndaelCipher = new RijndaelManaged())
                {
                    using (ICryptoTransform decryptor = rijndaelCipher.CreateDecryptor(secretKey.GetBytes(32), secretKey.GetBytes(16)))
                    {
                        byte[] encryptedData = Convert.FromBase64String(inputText);

                        using (MemoryStream memoryStream = new MemoryStream(encryptedData))
                        {
                            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] plainText = new byte[encryptedData.Length];
                                int decryptedCount = cryptoStream.Read(plainText, 0, plainText.Length);

                                return Encoding.Unicode.GetString(plainText, 0, decryptedCount);
                            }
                        }
                    }
                }
            }
        }
    }
}
