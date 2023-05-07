using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica5.Entities
{
    class Company : TaxPayer
    {
        public int numberOfEmployees;

        public Company(string name, double anualIncome, int numberOfEmployees)
            :base(name, anualIncome)
        {
            this.numberOfEmployees = numberOfEmployees;
        }
        public override double tax()
        {
            if (numberOfEmployees <= 10) /*16% tax*/
            {
                return anualIncome * 0.16;
            }
            else 
            {
                return anualIncome * 0.14;
            }
        }

    }
}
