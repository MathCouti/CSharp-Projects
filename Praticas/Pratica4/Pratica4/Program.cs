using Pratica4.Entities;
using System;
using System.Transactions;

class Program
{
    public static void Main(string[] args)
    {
        List<Product> produtos = new List<Product>();
        Console.WriteLine("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Common, used or imported (c/u/i)");
            char res = char.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            if(res == 'c') 
            {
                Product produto = new Product(name, price);
                produtos.Add(produto);
            }
            if (res == 'i')
            {
                Console.Write("Customs fee: ");
                double fee = double.Parse(Console.ReadLine());
                ImportedProduct produto = new ImportedProduct(name, price, fee);
                produtos.Add(produto);
            }
            if (res == 'u')
            {
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                UsedProduct produto = new UsedProduct(name, price, date);
                produtos.Add(produto);
            }

        }
        foreach (Product p in produtos)
        {
            Console.WriteLine(p.priceTag());
        }
    }

}