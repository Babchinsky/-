using System.Net;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        // Создание объекта Random
        Random random = new Random();

        // Генерация случайного пятизначного числа
        int randomNumber = random.Next(10000, 100000);

       


        // Ваши данные для отправки почты
        string smtpServer = "smtp.gmail.com";
        string smtpUsername = "buzzbus.company@gmail.com"; // Пароль почты Qwerty_123
        string smtpPassword = "kgrwndbatokruwvi";
        int smtpPort = 587; // Обычно порт 587 используется для шифрованного соединения (TLS)

        // Адрес получателя
        string toEmail = "alexseyb62@gmail.com";

        // Создание объекта SmtpClient
        SmtpClient client = new SmtpClient(smtpServer)
        {
            Port = smtpPort,
            Credentials = new NetworkCredential(smtpUsername, smtpPassword),
            EnableSsl = true, // Включение SSL для шифрованного соединения
        };


        string name = "TestName";
        // Создание объекта MailMessage
        MailMessage message = new MailMessage(smtpUsername, toEmail)
        {
            Subject = "Регистрация в вашем приложении",
            Body =  $"Подтверждение Регистрации\r\n\r\nДорогой {name},\r\n\r\nДобро пожаловать в наше сообщество! Мы очень рады видеть вас здесь.\r\n\r\nВаша учетная запись была успешно создана, и для завершения процесса регистрации, вам необходимо подтвердить свой аккаунт. Введите следующий пятизначный код при входе на нашем сайте:\r\n\r\nКод подтверждения: {randomNumber}\r\n\r\nСпасибо, что выбрали нас! Мы уверены, что ваш опыт с нашим сервисом будет приятным и полезным.\r\n\r\nЕсли у вас возникнут вопросы или вам потребуется дополнительная помощь, не стесняйтесь обращаться к нашей службе поддержки.\r\n\r\nС наилучшими пожеланиями,\r\nКоманда BuzzBus",
        };

        try
        {
            // Отправка сообщения
            client.Send(message);
            Console.WriteLine("Сообщение успешно отправлено");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при отправке сообщения: {ex.Message}");
        }
    }
}
