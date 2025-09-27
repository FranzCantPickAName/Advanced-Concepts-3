using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{

    public class Sample
    {
        public Tuple<string, int> GetPersonDetails()
        {
            Tuple<string, int> tuple = new Tuple<string, int>("Scott", 20);
            return tuple;
        }
    }

}

