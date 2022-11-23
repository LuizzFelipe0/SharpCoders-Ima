using System;

class Program
{
    static void Main(string[] args)
    {
       
        int number = int.Parse(Console.ReadLine());
        int hours =int.Parse(Console.ReadLine());
        double value = double.Parse(Console.ReadLine());

        double salary = value * hours;

        Console.WriteLine($"NUMBER {number}");
        Console.WriteLine($"SALARY = U$ {salary.ToString("0.00")}");



    }
}