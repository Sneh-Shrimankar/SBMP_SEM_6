using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.Write("Enter consumed units: ");
        int units = Convert.ToInt32(Console.ReadLine());
        
        if (units <= 200) {
            Console.WriteLine("Bill: " + (units * 0.50));
        } else if (units > 200 && units <= 400) {
            Console.WriteLine("Bill: " + (100 + units * 0.65));
        } else if (units > 400 && units <= 600) {
            Console.WriteLine("Bill: " + (230 + units * 0.80));
        } else {
            Console.WriteLine("Bill: " + (390 + units * 1));
        }
    }
  }
}