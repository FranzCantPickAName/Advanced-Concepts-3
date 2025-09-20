using System;

namespace ClassLibrary1
{

    /// <summary>
    /// Represents a product in the ECommerce application
    /// </summary>
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public DateTime DateOfManufacture {  get; set; }


    }

}
