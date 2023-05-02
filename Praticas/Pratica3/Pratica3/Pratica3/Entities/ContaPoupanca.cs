using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pratica3.Entities
{
    class ContaPoupanca : Conta
    {
        public double TaxaJuros;

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros)
            : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AdicionarJuros(double juros)
        { 
            TaxaJuros = juros;
        }
    }
}
