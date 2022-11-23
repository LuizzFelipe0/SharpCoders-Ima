using System; 

class URI {

    static void Main(string[] args) { 

        int number = Convert.ToInt16(Console.ReadLine());
        int hours = Convert.ToInt16(Console.ReadLine());
        double value = Convert.ToDouble(Console.ReadLine());

        double salary = (hours*value);

        Console.WriteLine($"NUMBER = {number}");
        Console.WriteLine($"SALARY = U$ " + salary.ToString("F2"));
        

    }

}