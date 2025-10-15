using System;

namespace ClassLibrary1
{
    [Serializable]
    public class Country
    {
        public short CountryID {  get; set; }
        public string CountryName { get; set; }
        public long Population {  get; set; }
        public string Region { get; set; }
    }

}
