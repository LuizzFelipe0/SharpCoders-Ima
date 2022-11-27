using System; 

class URI {

    static void Main(string[] args) { 

            int idade = int.Parse(Console.ReadLine());
           
            int ano = idade / 365;
            idade %= 365;
            
            int mes = idade / 30;
            idade %= 30;
           
            int dia = idade;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");

    }

}