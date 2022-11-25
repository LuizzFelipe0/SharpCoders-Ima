using System;

class URI
{

    static void Main(string[] args)
    {

        double preço1, preço2, total;
        int codigo1, codigo2, quantidade1, quantidade2;

        string[] valores = Console.ReadLine().Split(' ');

        codigo1 = int.Parse(valores[0]);
        quantidade1 = int.Parse(valores[1]);
        preço1 = double.Parse(valores[2]);

        valores = Console.ReadLine().Split(' ');

        codigo2 = int.Parse(valores[0]);
        quantidade2 = int.Parse(valores[1]);
        preço2 = double.Parse(valores[2]);

        total = ((preço1 * quantidade1) + (preço2 * quantidade2));

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));


    }

}