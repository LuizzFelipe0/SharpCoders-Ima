using System;

class URI
{

    static void Main(string[] args)
    {

        int cedulas = int.Parse(Console.ReadLine());
        Console.WriteLine(cedulas);

        Console.WriteLine($"{cedulas / 100} nota(s) de R$ 100,00");
        cedulas = cedulas % 100;

        Console.WriteLine($"{cedulas / 50} nota(s) de R$ 50,00");
        cedulas = cedulas % 50;

        Console.WriteLine($"{cedulas / 20} nota(s) de R$ 20,00");
        cedulas = cedulas % 20;

        Console.WriteLine($"{cedulas / 10} nota(s) de R$ 10,00");
        cedulas = cedulas % 10;

        Console.WriteLine($"{cedulas / 5} nota(s) de R$ 5,00");
        cedulas = cedulas % 5;

        Console.WriteLine($"{cedulas / 2} nota(s) de R$ 2,00");
        cedulas = cedulas % 2;

        Console.WriteLine($"{cedulas / 1} nota(s) de R$ 1,00");
    }

}