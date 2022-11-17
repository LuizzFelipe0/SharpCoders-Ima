using System;

class URI
{

    static void Main(string[] args)
    {

        double nota1, nota2, media;

        nota1 = double.Parse(Console.ReadLine());
        nota2 = double.Parse(Console.ReadLine());

        media = (nota1 * 3.5 + nota2 * 7.5) / 11;

        Console.WriteLine($"MEDIA = {media:F2}" );



    }

}