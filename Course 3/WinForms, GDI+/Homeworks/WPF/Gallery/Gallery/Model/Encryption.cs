using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    public class Encryption
    {
        public static string EncodeToBase64(string plainText)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(bytes);
        }

        public static string DecodeFromBase64(string base64EncodedText)
        {
            byte[] bytes = Convert.FromBase64String(base64EncodedText);
            return Encoding.UTF8.GetString(bytes);
        }

        // Генерация соли
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16]; // 16 байт для соли (можно выбрать другой размер)
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
        // Хеширование пароля с использованием соли
        public static string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Конкатенация пароля и соли
                string saltedPassword = password + salt;

                // Преобразование строки пароля и соли в массив байтов
                byte[] passwordBytes = Encoding.UTF8.GetBytes(saltedPassword);

                byte[] hashedBytes = SHA256.HashData(passwordBytes);

                // Преобразование массива байтов в строку в формате HEX
                StringBuilder stringBuilder = new();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    stringBuilder.Append(hashedBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}
