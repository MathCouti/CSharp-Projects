using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pratica5.Entities
{
    class Individual : TaxPayer
    {
        public double healthExpenditures;

        public Individual(string name, double anualIncome, double healthExpenditures)
            :base(name, anualIncome)
        {
            this.healthExpenditures = healthExpenditures;
        }

        public override double tax()
        {
            if (anualIncome <= 20000.00)
            {
                if (healthExpenditures > 0)
                {
                    return (anualIncome * 0.15) - (healthExpenditures / 2);
                }
                else
                {
                    return anualIncome * 0.15;
                }
            }
            else
            {
                if (healthExpenditures > 0)
                {
                    return (anualIncome * 0.25) - (healthExpenditures / 2);
                }
                else
                {
                    return anualIncome * 0.25;
                }
            }   
            
        }
     
    }
}
