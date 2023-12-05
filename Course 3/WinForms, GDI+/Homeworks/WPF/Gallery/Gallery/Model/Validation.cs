using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gallery.Model
{
    public class Validation
    {
        public static bool IsValidEmail(string email)
        {
            // Простая проверка с использованием регулярного выражения
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        public static bool IsValidPassword(string password)
        {
            // Пример: Пароль должен содержать минимум 8 символов, включая цифры, буквы верхнего и нижнего регистров
            return password.Length >= 8 &&
                   ContainsDigit(password) &&
                   ContainsLowercaseLetter(password) &&
                   ContainsUppercaseLetter(password);
        }
        private static bool ContainsDigit(string input)
        {
            return input.Any(char.IsDigit);
        }
        private static bool ContainsLowercaseLetter(string input)
        {
            return input.Any(char.IsLower);
        }
        private static bool ContainsUppercaseLetter(string input)
        {
            return input.Any(char.IsUpper);
        }
    }
}
