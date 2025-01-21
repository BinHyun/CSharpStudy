using System;

namespace ConsoleApp1
{
    class Program : ChildClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("------------");
            Console.WriteLine("------------");
            Console.WriteLine("Call ChildClass");
            Console.WriteLine("------------");
            Console.WriteLine("------------");
           
            Program p = new();
            p.ChildMain();

        }
    }
}