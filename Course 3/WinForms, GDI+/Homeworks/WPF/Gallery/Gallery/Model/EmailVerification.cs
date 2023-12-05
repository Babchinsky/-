using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Model
{
    public class EmailVerification
    {
        // Ваши данные для отправки почты
        private string smtpServer = "smtp.gmail.com";
        private string smtpUsername = "visioarts.company@gmail.com"; // Пароль почты Qwerty_123
        private string smtpPassword = "krdtpbmhmcenxagy";
        private int smtpPort = 587; // Обычно порт 587 используется для шифрованного соединения (TLS)

        private SmtpClient smtpClient;

        public EmailVerification()
        {
            // Создание объекта SmtpClient
            smtpClient = new SmtpClient(smtpServer)
            {
                Port = smtpPort,
                Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                EnableSsl = true, // Включение SSL для шифрованного соединения
            };
        }

        public void SendMessage(string number, string toEmail)
        {

            // Создание объекта MailMessage
            MailMessage message = new MailMessage(smtpUsername, toEmail)
            {
                Subject = "Регистрация в вашем приложении",
                Body = $"Подтверждение Регистрации\r\n\r\nДорогой пользователь,\r\n\r\nДобро пожаловать в наше сообщество! Мы очень рады видеть вас здесь.\r\n\r\nВаша учетная запись была успешно создана, и для завершения процесса регистрации, вам необходимо подтвердить свой аккаунт. Введите следующий пятизначный код при входе на нашем сайте:\r\n\r\nКод подтверждения: {number}\r\n\r\nСпасибо, что выбрали нас! Мы уверены, что ваш опыт с нашим сервисом будет приятным и полезным.\r\n\r\nЕсли у вас возникнут вопросы или вам потребуется дополнительная помощь, не стесняйтесь обращаться к нашей службе поддержки.\r\n\r\nС наилучшими пожеланиями,\r\nКоманда BuzzBus",
            };

            try
            {
                // Отправка сообщения
                smtpClient.Send(message);
                //Console.WriteLine("Сообщение успешно отправлено");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при отправке сообщения: {ex.Message}");
            }
        }

    }
}
