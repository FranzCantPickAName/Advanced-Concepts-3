using System;

namespace ClassLibrary1
{

    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message) { }

    }

}
