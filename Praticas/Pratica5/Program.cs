using Pratica5.Entities;
using System;

class Program
{
    static void Main(string[] args)
    {
        double sum = 0.0;
        List<TaxPayer> list = new List<TaxPayer>();
        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Tax Payer {(i+1)} data:");
            Console.Write("Individual or company [i / c]");
            char res = char.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual Income: ");
            double income = double.Parse(Console.ReadLine());
            if (res == 'i')
            {
                Console.Write("Health expenditures: ");
                double health = double.Parse(Console.ReadLine());
                list.Add(new Individual(name, income, health));
            }
            else
            {
                Console.Write("Number of employees: ");
                int employees = int.Parse(Console.ReadLine());
                list.Add(new Company(name, income, employees));
            }
        }
        foreach(TaxPayer taxPayer in list)
        {
            Console.WriteLine("Name: " + taxPayer.name
               + "\nTaxes Paid: " + taxPayer.tax().ToString("F2")
                ); ;
            double tax = taxPayer.tax();
            sum += tax;
        }
        Console.WriteLine("Total Taxes Paid: " + sum.ToString("F2"));


    }

}