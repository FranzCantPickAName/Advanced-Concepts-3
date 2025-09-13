using System;

namespace ClassLibrary1
{
    public class SmsEventArgs : EventArgs
    {
        public string Sender { get; set; }
        public string Content { get; set; }
    }
}
