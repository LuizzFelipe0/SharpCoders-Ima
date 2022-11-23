using System;

class URI
{

    static void Main(string[] args)
    {

        string name = Convert.ToString(Console.ReadLine());
        double salary = Convert.ToDouble(Console.ReadLine());
        double sales = Convert.ToDouble(Console.ReadLine());

        double salaryBonus = ((sales * 0.15) + salary);

        Console.WriteLine($"TOTAL = R$ " + salaryBonus.ToString("F2"));
        


    }

}