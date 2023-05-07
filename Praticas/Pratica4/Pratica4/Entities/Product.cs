using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica4.Entities
{
    class Product
    {
        public string name { get; protected set; }
        public double price { get; protected set; }

        public Product()
        { }
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual string priceTag()
        {
            return "\nName: " + name
                + "\nPrice: R$" + price;
        }
    }
}
