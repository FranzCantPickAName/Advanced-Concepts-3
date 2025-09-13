using System;

namespace ClassLibrary1
{

    public class SmsService
    {

        public event EventHandler<SmsEventArgs> SmsReceived;

        public void ReceiveSms(string sender, string content)
        {
            Console.WriteLine($"📧 SMS Received from {sender}");

            SmsReceived?.Invoke(this, new SmsEventArgs
            {
                Sender = sender,
                Content = content
            });

        }


    }

}
