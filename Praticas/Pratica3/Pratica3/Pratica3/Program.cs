using Pratica3.Entities;
using System;

class Program
{
    public static void Main(string[] args)
    { 
        Conta c = new Conta(1234, "Matheus", 0.0);

        Console.WriteLine(c.Titular);

        Conta c2 = new ContaPoupanca(12345, "Thais", 0.0, 0.01);

        Conta c3 = c2;
    }
}