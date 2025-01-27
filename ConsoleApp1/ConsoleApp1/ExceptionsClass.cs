using System;

namespace ConsoleApp1
{
    class ExceptionsClass
    {
        public void ExceptionsMain()
        {
            Console.WriteLine("나눌 숫자를 입력 하세요.");
            int num = int.Parse(Console.ReadLine());
            try
            {
               Console.WriteLine(10 / num);
            }
            catch (Exception e)
            {
               Console.WriteLine("예외발생 : " + e.Message);
            }
            
        }
    }
}