using System;
using System.Collections.Generic;
using System.Text;

namespace PS.domain
{
    public class Product:Concept
    {
        public DateTime DateProd { get; set; }
        public String Descriptin { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Category MyCategory { get; set; }
        public IList<Provider> Providers { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Name:" + Name + "Price: " + Price);
        }
    }
}
