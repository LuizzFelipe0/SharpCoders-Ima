using System;
internal class Program
{

    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        int n1 = int.Parse(input[0]);
        int n2 = int.Parse(input[1]);
        int n3 = int.Parse(input[2]);

        int maior = (n1 + n2 + Math.Abs(n1 - n2)) / 2;

        maior = (n3 + maior + (Math.Abs(maior - n3))) / 2;

        Console.WriteLine($"{maior} eh o maior");

    }
}
