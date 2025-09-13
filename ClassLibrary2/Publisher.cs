using System;

namespace ClassLibrary1
{

    public class Publisher
    {

        //Action:
        public event Action<int, int> myEvent;

        public void RaiseEvent(int a, int b)
        {

            if (this.myEvent != null)
            {
                this.myEvent(a, b);
            }

        }


    }

}
