using SalarioEmpregado.Entities.Enums;
using SalarioEmpregado.Entities;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter department's name: ");
        string deptName = Console.ReadLine();
        Console.WriteLine("Enter worker data ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Level (Junior / MidLevel / Senior)");
        WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
        Console.Write("Base Salary: ");
        double salary = double.Parse(Console.ReadLine());

        Department dept = new Department(deptName);
        Worker worker = new Worker(name, salary, level, dept);

        Console.Write("How many contracts to this work? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine($"Enter #{(i+1)} contract data:");
            Console.Write("Date (DD/MM/YYYY) ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuehour = double.Parse(Console.ReadLine());
            Console.Write("Duration (hours): ");
            int hour = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(data, valuehour, hour);
            worker.AddContract(contract);
        }
        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string monthAndYear = Console.ReadLine();
        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));
        Console.WriteLine("Name : " + worker._name);
        Console.WriteLine("Department: " + worker._depart);
        Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2"));
    }

}

