using System;
using System.Collections.Generic;

namespace Dependency_Inversion
{
    //Bad Example-------------------------
    //public class Email
    //{
    //    public string ToAddress { get; set; }
    //    public string Subject { get; set; }
    //    public string Content { get; set; }
    //    public void SendEmail()
    //    {
    //        //Send email
    //    }
    //}

    //public class SMS
    //{
    //    public string PhoneNumber { get; set; }
    //    public string Message { get; set; }
    //    public void SendSMS()
    //    {
    //        //Send sms
    //    }
    //}
    //public class Notification
    //{
    //    private Email _email;
    //    private SMS _sms;
    //    public Notification()
    //    {
    //        _email = new Email();
    //        _sms = new SMS();
    //    }

    //    public void Send()
    //    {
    //        _email.SendEmail();
    //        _sms.SendSMS();
    //    }
    //}
    //Good Example--------------------------------------
    public interface IMessage
    {
        void SendMessage();
    }
    public class Email : IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            //Send email
        }
    }

    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            //Send sms
        }
    }
    public class Notification
    {
        private ICollection<IMessage> _messages;

        public Notification(ICollection<IMessage> messages)
        {
            this._messages = messages;
        }
        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
    //Dependency inversion prinsipinde oldugu kimi Yuxarı səviyyəli modullar birbaşa aşağı səviyyəli modullardan asılı olmamalıdır.
    //Beləliklə, SOLID prinsipləri asılılıqları azaltmaqla bağlı olduğundan,
    //Bildiriş və E -poçt/SMS arasındakı asılılığı aradan qaldırmaq üçün bu kodu necə yenidən düzəldə bilərik? Bildirişin etibar edə biləcəyi və E -poçt və SMS -in tətbiq edə biləcəyi bir soyutlama təqdim etməliyik.
    //Buna IMessage deyək.Sonra, E -poçt və SMS IMessage interfeysini tətbiq edir.Ve belelikle asilligi minimum hala saldiq


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
