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

// OOPS in C#
using System;

namespace oopsConcepts
{
    class OOPS
    {
        string Variant;
         string color = "Grey";
      int mileage = 17;
        string mileage_variable="Km/Hour";
        string CarName;
        public void Steer()
        {
            Console.WriteLine("Model Name"+"......."+ " 2022 Porsche Cayenne");
        }
        static void Main(string[] args)
        {
            OOPS myObject = new OOPS();
           myObject.Variant = "Diesel";
            Console.WriteLine("Diesel or Petrol?");
            Console.WriteLine(myObject.Variant);
            Console.WriteLine("Mileage dude?");
            Console.WriteLine(myObject.mileage+" "+myObject.mileage_variable);
            Console.WriteLine("Tell me about your color:");
            Console.WriteLine(myObject.color);
            myObject.CarName = "Porsche";
            Console.WriteLine("Which Brand?");
            Console.WriteLine(myObject.CarName);


           myObject.Steer();

           Console.ReadLine();
        }
      }
}
//Access Modifiers in C#
using System;
namespace publicAccessModifier
{

    class Car
    {

        // Declaring members modelno
        // and name as public
        public int modelno;
        public string name;

        // Constructor
        public Car(int m, string n)
        {
            modelno = m;
            name = n;
        }

        // methods getmodelno and getName
        // also declared as public
        public int getmodelno()
        {
            return modelno;
        }
        public string getName()
        {
            return name;
        }
    }

    class Program
    {

        // Main Method
        static void Main(string[] args)
        {
            // Creating object of the class Car
            Car C = new Car(911, "Porsche Caynenne");

            // Displaying details directly
            // using the class members
            // accessible through another method
            Console.WriteLine("Model number: {0}", C.modelno);
            Console.WriteLine("Name: {0}", C.name);

            Console.WriteLine();

            // Displaying details using
            // member method also public
            Console.WriteLine("Model number: {0}", C.getmodelno());
            Console.WriteLine("Name: {0}", C.getName());
        }
    }
}

//single level inheritance
using System;
public class A//base class
{
    public int i = 23;
    public void f1()
    {
        Console.WriteLine("Method of base class");

           }

}
public class B: A// derived class/child class
{
     int j = 27;
    public void multi()
   {
       Console.WriteLine(i * j);
    }
}
 class C
{
    public static void Main(string[] args)
    {
       B b = new B();
       b.f1();
       b.multi();

       Console.ReadLine();

   }
}

 Multiple level Inheritance
using System;
public class A
{
    public void m1()
    {
        Console.WriteLine("method of class A");
    }
}
public class B : A
{
    public void m2()
    {
        Console.WriteLine("Method of class B");
    }
}
public class C:B
{
    public void m3()
    {
        Console.WriteLine("Method of class C");
    }
}
class D
{
     static void Main(string[] args)
    {
        C c1=new C();
        c1.m1();
        c1.m2();
        c1.m3();
        Console.ReadLine();
    }
}
// polymorphism method overloading
using System;
public class A
{
    public void f1()//without aguments
    {
        Console.WriteLine("method without arguments");

    }  
    public void f1(int i, int j)//with two arguments
    {
        Console.WriteLine(i + j);
    }
}
public class B
{
    static void Main(string[] args)
    {
        A a = new A();
        a.f1();
        a.f1(75, 5);
        Console.ReadLine();
    }
}
//polymorphism method overriding
using System;
public class A
{
    public void f1()
    {
        Console.WriteLine("Method of base class");
    }
    public class B : A
    {
        public void f1()
        {
            Console.WriteLine("Hi, Mriyam from derive class");
        }

    }
    class C
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.f1();
            Console.ReadLine();
        }
    }
}
//Abstracts Method
using System;
public abstract class A
{
    public abstract void f1();
        public void f2()
    {
        Console.WriteLine("f2");
    }


}
class B : A
{
    public override void f1()
    {
        Console.WriteLine("Mriyam");
    }
}
public class main
{
    static void Main(string[] args)
    {
        B b = new B();
        b.f1();
        b.f2();
        Console.ReadLine();

    }
}
//Two dimensional array to one dimensional array
using System;

class Conversion_of_array
{
    static void Main(string[] args)
    {
        int[,] twodarr = new int[3, 3];
        Console.Write("Enter 2D Array Elements : ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                twodarr[i, j] = Convert.ToInt32(Console.ReadLine());
               
            }
           
        }

        int index = 0;


        int row = twodarr.GetLength(0);


        int col = twodarr.GetLength(1);


        int[] onedarr = new int[row * col];


        for (int j = 0; j < col; j++)
        {
            for (int i = 0; i < row; i++)
            {
                onedarr[index] = twodarr[i, j];
                index++;
            }
        }

        Console.WriteLine("1D Array Elements : ");
        foreach (int item in onedarr)
        {
            Console.Write(item + " ");
        }

        Console.ReadKey();
    }
}



