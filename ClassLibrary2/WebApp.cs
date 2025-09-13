using System;

namespace ClassLibrary1
{
    public class WebApp
    {
        public void OnSmsReceived(object sender, SmsEventArgs e)
        {
            Console.WriteLine($"💻 WebApp -> Displaying SMS: {e.Content}");
        }
    }
}