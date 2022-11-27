using System;

class URI
{

    static void Main(string[] args)
    {
        int tempo = int.Parse(Console.ReadLine());

        int hora = tempo / 3600;
        int minuto = (tempo - hora * 3600) / 60;
        int segundo = tempo - hora * 3600 - minuto * 60;

        Console.WriteLine($"{hora}:{minuto}:{segundo}");

    }

}