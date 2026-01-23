using System.Windows.Controls;
using System;
using System.Net;
using System.Net.Mail;

namespace SimpleSendEmailClient;


public partial class SendEmailPage : Page
{
    public SendEmailPage(string login, string password)
    {
        InitializeComponent();

        Login = login;
        Password = password;

    }

    public string Login {
        get;

        private set;
    }

    public string Password {
        get;

        private set;
    }

    private void SendButton_Click(object sender, System.Windows.RoutedEventArgs e) {

        // Получение текста с полей
        string fromText = FromField.Text;
        string toText = ToField.Text;
        string subjectText = SubjectField.Text;
        string bodyText = BodyField.Text;

        // Создание объекта почты
        MailMessage email = new MailMessage();
        email.From = new MailAddress(fromText);
        email.To.Add(new MailAddress(toText));
        email.Subject = subjectText;
        email.Body = bodyText;
        email.IsBodyHtml = true;

        // Создание объекта SMTPClient и настройка конфигов
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.yandex.ru";
        smtp.Port = 465;                        // Порты могут быть 587, 465 или 25
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.UseDefaultCredentials = false; // Must be false if providing specific credentials
        smtp.Credentials = new NetworkCredential(Login, Password);

        try {
            // Отправка письма
            smtp.Send(email);
            Console.WriteLine("Письмо успешно отправлено!");
        }
        catch (SmtpException ex) {
            Console.WriteLine($"SmtpException: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
        catch (Exception ex) {
            Console.WriteLine($"Exception: {ex.Message}");
        }

    }
}
