// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //int x = 10;
             //int y = 25;
             double d = 5.234D;
             bool b = true;
             char c = 'y';
             //Console.WriteLine(Convert.ToString(x));
             Console.WriteLine(Convert.ToDouble(y));
             Console.WriteLine(Convert.ToBoolean(y));
             Console.WriteLine(Convert.ToInt64(d));
             Console.WriteLine(Convert.ToInt64(b));
             Console.WriteLine(Convert.ToString(b));
             Console.WriteLine(Convert.ToChar(y));
             Console.WriteLine(Convert.ToInt32(c));*/

            string word = "Mindteck";

            string w = "";

            for (int i=word.Length-1; i>=0; i--)
            {
                w = w+word[i];
                              
             }
            Console.WriteLine(w);



        }

        
    }
}
//Delegate in C#
using System;
using System.Linq;

namespace Delegate 
{
    internal class Program
    {
        public delegate void addnumber(int a, int b);
        public delegate void subnumber(int a, int b);
        public delegate void multinumber(int a, int b);
        public delegate void divinumber(int a, int b);
        public void sum(int a, int b)
        {
            Console.WriteLine("{0}", a+b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("{0}", a - b);
        }
        public void mul(int a, int b)
        {
            Console.WriteLine("{0}", a * b);
        }
        public void div(int a, int b)
        {
            Console.WriteLine("{0}", a / b);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            addnumber delObj1 = new addnumber(obj.sum);
            subnumber delObj2 =new subnumber(obj.sub);
            multinumber delObj3 = new multinumber(obj.mul);
            divinumber delObj4 = new divinumber(obj.div);

            delObj1 (23,10);
            delObj2(24, 7);
            delObj3(12, 6);
            delObj4(49, 7);
    
        }

        


  
        }
    }

// TryCatchMethod in C#
using System;
class TryCatchMethod {
  static void Main() {
   try
{
  int[] arr = {1, 2, 3};
  Console.WriteLine(arr[2]);
  Console.WriteLine(arr[10]);
}
catch (Exception ex)
{
  Console.WriteLine(ex.Message);
}
  }
}

