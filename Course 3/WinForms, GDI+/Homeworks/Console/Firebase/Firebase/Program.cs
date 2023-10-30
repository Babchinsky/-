using System;
using System.Threading.Tasks;
using FirebaseAdmin.Auth;
using FirebaseAuthentication;

class Program
{
    static async Task Main(string[] args)
    {
        string apiKey = "YOUR_API_KEY";

        FirebaseAuth auth = new FirebaseAuth(apiKey);

        Console.Write("Введите адрес электронной почты: ");
        string email = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        try
        {
            var signUpResponse = await auth.SignUpWithEmailAndPasswordAsync(email, password);

            if (signUpResponse.Success)
            {
                Console.WriteLine("Пользователь успешно зарегистрирован.");
                Console.WriteLine("UID пользователя: " + signUpResponse.User.LocalId);
            }
            else
            {
                Console.WriteLine("Ошибка при регистрации: " + signUpResponse.Reason);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        Console.WriteLine("Нажмите любую клавишу для завершения...");
        Console.ReadKey();
    }
}
