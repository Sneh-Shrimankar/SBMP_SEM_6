using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.Write("Enter basic salary: ");
        double basic = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter level of employee: ");
        int level = Convert.ToInt32(Console.ReadLine());
        
        double hra = basic * 0.25;
    
        double ca, ea, gross = 0 ;
        switch(level)
        {
            case 1: ca = 1000;
                    ea = 500;
                    
                    gross = basic + ca + ea + hra;
                    
                    break;
                    
            case 2: ca = 750;
                    ea = 200;
                    
                    gross = basic + ca + ea + hra;
                    
                    break;
                    
            case 3: ca = 500;
                    ea = 100;
                    
                    gross = basic + ca + ea + hra;
                    
                    break;
            
            case 4: ca = 250;
                    
                    gross = basic + ca + hra;
                    
                    break;
                    
            default: Console.WriteLine("Error");
                        break;
        } 
        
        Console.WriteLine("Gross salary: " + gross);
    }
  }
}