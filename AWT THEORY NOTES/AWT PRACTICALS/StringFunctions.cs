using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string name = "John";
        string str1 = "Hello";
        
        // Concat
        Console.WriteLine(string.Concat(str1, " World"));
        
        // String interpolation
        string message = $"Welcome, {name}";
        Console.WriteLine(message);
        
        // Char to String
        char[] ch = {'c', 's', 'h', 'a', 'r', 'p'};
        string str2 = new string (ch);
        Console.WriteLine(str2);
        
        // Length
        Console.WriteLine(str1.Length);
        
        // Equals
        Console.WriteLine("\n" + str1.Equals(str2));
        
        // Compare
        Console.WriteLine("\n" + str1.CompareTo(str2));
        
        // Index
        Console.WriteLine(name.IndexOf("h"));
        
        // Join
        Console.WriteLine(string.Join(' ', str1, str2));
        
        // Separator
        string str3 = "Welcome to C# programming world";
        string[] separator = {""};
        Int32 count = 3;
        
        string[] strlist = str3.Split(separator, count, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (string s in strlist) {
            Console.WriteLine(s + "\n");
    }
}