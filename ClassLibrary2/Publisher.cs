using System;

namespace ClassLibrary1
{

    public class Publisher
    {

        public event Predicate<int> myEvent;

        public bool RaiseEvent(int a)
        {

            if (this.myEvent != null)
            {
                bool result = this.myEvent(a);
                return result;
            }
            else
            {
                return false;
            }

        }


    }

}
