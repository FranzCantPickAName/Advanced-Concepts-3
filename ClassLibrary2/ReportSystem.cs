using System;

namespace ClassLibrary1
{
    public class ReportSystem
    {
        public void OnSmsReceived(object sender, SmsEventArgs e)
        {
            Console.WriteLine($"📊 ReportSystem -> Logged SMS from {e.Sender}");
        }
    }
}
