using System;

namespace ConsoleApp1
{
    class LoopClass
    {
        public void LoopMain()
        {
            /* for 반복문 예시
             for(int i=1; i<11; i++)
               Console.WriteLine(i);
            */

            int i = 1;
            while(i<11)
            {
                Console.WriteLine(i);
                i++;
            }
                
        }
    }
}