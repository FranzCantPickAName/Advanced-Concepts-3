using System;

namespace ClassLibrary1
{

    public delegate void MyDelegateType(int a, int b);
    public class Publisher
    {
        //Not needed with auto implemented event
        //private MyDelegateType myDelegate;

        //public event MyDelegateType myEvent
        //{
        //    add
        //    {
        //        myDelegate += value;
        //    }
        //    remove
        //    {
        //        myDelegate -= value;
        //    }
        //}
        public event MyDelegateType myEvent;

        public void RaiseEvent(int a, int b)
        {
            //if (this.myDelegate != null)
            //{
            //    this.myDelegate(a, b);
            //}
            if (this.myEvent != null)
            {
                this.myEvent(a, b);
            }

        }


    }

}
