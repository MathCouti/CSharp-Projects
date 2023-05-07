using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica5.Entities
{
    abstract class TaxPayer
    {
        public string name { get; set; }
        public double anualIncome { get; set; }

        public TaxPayer(string name, double anualIncome) 
        { 
            this.name = name;
            this.anualIncome = anualIncome;
        }

        abstract public double tax();


    }
}
