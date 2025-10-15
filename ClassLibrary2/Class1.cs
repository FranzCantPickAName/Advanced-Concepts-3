using System;


namespace ClassLibrary1
{
    [Serializable]
    public class Customer
    {
        public int CustomerID {  get; set; }
        public string CustomerName { get; set; }

        //Hmm? Currently being serialized anyway
        [NonSerialized] public int age;
    }

}
