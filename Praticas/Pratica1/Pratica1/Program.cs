using System;
using System.Collections.Concurrent;

class Program
{
    static public void Main(string[] args)
    {
        DateTime d1 = DateTime.Now;

        DateTime d2 = d1.AddDays(1);

        Console.WriteLine(d2);

    }


}