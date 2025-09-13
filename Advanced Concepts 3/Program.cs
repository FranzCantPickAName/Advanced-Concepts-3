using ClassLibrary1;
using System;
using System.Linq.Expressions;

namespace EventsSample
{
    class Program
    {
        static void Main()
        {
            SmsService smsService = new SmsService();

            MobileApp mobile = new MobileApp();
            WebApp web = new WebApp();
            ReportSystem report = new ReportSystem();

            smsService.SmsReceived += mobile.OnSmsReceived;
            smsService.SmsReceived += web.OnSmsReceived;
            smsService.SmsReceived += report.OnSmsReceived;

            smsService.ReceiveSms("09120000000", "Sup bro");
            Console.WriteLine();
            smsService.ReceiveSms("09350000000", "Don't forget 10 o'clock meeting");

            Console.ReadKey();
        }

            
            
    }

}