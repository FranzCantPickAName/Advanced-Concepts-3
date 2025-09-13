using System;

namespace ClassLibrary1
{
    public class MobileApp
    {
        public void OnSmsReceived(object sender, SmsEventArgs e)
        {
            Console.WriteLine($"📱 MobileApp -> New SMS from {e.Sender}: {e.Content}");
        }
    }
}
