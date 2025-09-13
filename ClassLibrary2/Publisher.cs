using System;

namespace ClassLibrary1
{

    //public delegate int MyDelegateType(int a, int b);
    public class Publisher
    {

        //public event MyDelegateType myEvent;

        //Event func:
        public event Func<int, int, int> myEvent;

        public int RaiseEvent(int a, int b)
        {
            
            if (this.myEvent != null)
            {
                int x = this.myEvent(a, b);
                return x;
            }
            else
            {
                return 0;
            }

        }


    }

}
