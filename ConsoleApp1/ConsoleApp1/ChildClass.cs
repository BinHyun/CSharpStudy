using System;

namespace ConsoleApp1
{
    class ChildClass
    {
        public void ChildMain()
        {
            /*
            c#의 경우 변수의 타입을 앞에 붙여준다.
            - bool은 불린형 (true, false)
            - int는 정수형
            - float는 실수형
            - char는 문자형
            */
            bool boolVariable = true;
            int intVariable = 10;
            float floatVariable = 3.4f;
            char chatVariable = 'a';

            Console.WriteLine("boolVariable ==> " + boolVariable);
            Console.WriteLine("intVariable ==> " + intVariable);
            Console.WriteLine("floatVariable ==> " + floatVariable);
            Console.WriteLine("chatVariable ==> " + chatVariable);
        }
    }
}