using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split(' ');
        double A = double.Parse(input[0], CultureInfo.InvariantCulture),B = double.Parse(input[1], CultureInfo.InvariantCulture),C = double.Parse(input[2], CultureInfo.InvariantCulture);
        
        var Triangulo = (A * C) / 2;
        var Circulo = (3.14159 * (C * C));
        var Trapezio = ((A + B) * C) / 2;
        var Quadrado = B * B;
        var Retangulo = A * B;
        
        Console.WriteLine("TRIANGULO: " + Triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + Circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + Trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + Quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + Retangulo.ToString("F3", CultureInfo.InvariantCulture));


    }

}