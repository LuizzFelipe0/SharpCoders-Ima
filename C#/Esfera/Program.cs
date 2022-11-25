using System;

class URI
{

    static void Main(string[] args)
    {

        double raio, volume, pi = 3.14159;

        string[] valores = Console.ReadLine().Split(' ');

        raio = double.Parse(valores[0]);
        volume = ((4.0 / 3.0) * pi * (raio * raio * raio));

        Console.WriteLine("VOLUME = " + volume.ToString("F3"));



    }

}