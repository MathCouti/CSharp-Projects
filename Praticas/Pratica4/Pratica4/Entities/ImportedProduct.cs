using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pratica4.Entities
{
    class ImportedProduct : Product
    {
        public double customFee;

        public ImportedProduct()
        { }
        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            this.customFee = customFee;
        }

        public override string priceTag()
        {
            return base.priceTag()
            + "\nCustom Fee: " + customFee;
        }
    }
}
