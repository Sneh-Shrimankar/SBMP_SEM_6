using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        int a, b;
        
        Console.WriteLine("Enter a:");
        a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter b:");
        b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Addition: " + (a + b));
    }
  }
}