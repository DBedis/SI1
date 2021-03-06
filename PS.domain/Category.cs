using System;
using System.Collections.Generic;
using System.Text;

namespace PS.domain
{
    public class Category:Concept
    {
        public int CategoryId{ get; set; }
        public string Name { get; set; }
        public IList<Product> Products { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Name:" + Name + "CategoryId: " + CategoryId);
        }
    }
}
