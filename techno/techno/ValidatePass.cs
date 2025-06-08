using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace techno
{
    internal class ValidatePass
    {
        public static (bool IsValid, string ErrorMessage) check(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return (false, "Пароль не может быть пустым.");
            }

            else if (password.Length < 8)
            {
                return (false, "Пароль должен содержать не менее 8 символов.");
            }

            else if (!Regex.IsMatch(password, @"^[a-zA-Z0-9!@#$%^&*()_+=-]+$"))
            {
                return (false, "Пароль должен содержать только латинские символы, цифры и специальные символы.");
            }

            else if (!Regex.IsMatch(password, @"[a-z]+"))
            {
                return (false, "Пароль должен содержать хотя бы одну маленькую букву.");
            }

            else if (!Regex.IsMatch(password, @"[A-Z]+"))
            {
                return (false, "Пароль должен содержать хотя бы одну заглавную букву.");
            }

            else if (!Regex.IsMatch(password, @"[0-9]+"))
            {
                return (false, "Пароль должен содержать хотя бы одну цифру.");
            }

            else if (!Regex.IsMatch(password, @"[!@#$%^&*()_+\-=\\]+"))
            {
                return (false, "Пароль должен содержать хотя бы один специальный символ.");
            }

            else
                return (true, null); // Пароль подходит требованиям
        }
    }
}
