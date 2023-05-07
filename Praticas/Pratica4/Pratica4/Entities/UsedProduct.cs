using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Pratica4.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate;

        public UsedProduct()
        { }
        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }
        public override string priceTag()
        {
            return base.priceTag()
            + "\nManufacture Date: " + manufactureDate;
        }

    }
}
