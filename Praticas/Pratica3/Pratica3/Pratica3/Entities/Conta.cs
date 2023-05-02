using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3.Entities
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }


        public Conta()
        { }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }   
    }
}
