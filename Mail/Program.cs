using System;
using System.Net;
using System.Net.Mail;

namespace Mail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите свою почту");
            string no = Console.ReadLine();
            Console.WriteLine("Укажите свое имя");
            string name = Console.ReadLine();
            MailAddress from = new MailAddress(no, name);

            Console.WriteLine("Укажите почту получателя");
            string mail = Console.ReadLine();
            MailAddress to = new MailAddress(mail);

            using (MailMessage sim = new MailMessage(from, to))
            using (SmtpClient car = new SmtpClient())

            {
                Console.WriteLine("Тема вашего сообщения");
                sim.Subject = Console.ReadLine();
                Console.WriteLine("Введите текст");
                sim.Body = Console.ReadLine();
                sim.IsBodyHtml = true;


                car.Host = "smtp.yndex.com";
                car.Port = 587;
                car.EnableSsl = true;

                Console.WriteLine("Пароль");
                string a = Console.ReadLine();
                car.Credentials = new NetworkCredential(no, a);
                car.Send(sim);
            }

        }
    }
}
