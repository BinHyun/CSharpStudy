using System;

namespace ConsoleApp1
{
    class Program : OperandClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("------------");
            Console.WriteLine("------------");
            Console.WriteLine("Call OperandClass");
            Console.WriteLine("------------");
            Console.WriteLine("------------");
           
            Program p = new();
            p.OperandMain();

        }
    }
}