using System; 

class URI {

    static void Main(string[] args) { 

     double raio, area, pi = 3.14159;

     raio = double.Parse(Console.ReadLine());
    
     area = pi * (raio*raio);
     
    Console.WriteLine($"A={area:F5}");



    }

}