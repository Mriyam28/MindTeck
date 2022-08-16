// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 25;
            double d = 5.234D;
            bool b = true;
            char c = 'y';
            Console.WriteLine(Convert.ToString(x));
            Console.WriteLine(Convert.ToDouble(y));
            Console.WriteLine(Convert.ToBoolean(y));
            Console.WriteLine(Convert.ToInt64(d));
            Console.WriteLine(Convert.ToInt64(b));
            Console.WriteLine(Convert.ToString(b));
            Console.WriteLine(Convert.ToChar(y));
            Console.WriteLine(Convert.ToInt32(c));
            
        }

        
    }
}
