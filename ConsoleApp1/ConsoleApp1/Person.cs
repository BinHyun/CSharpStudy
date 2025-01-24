using System;

namespace ConsoleApp1
{
    //class의 이름은 보통 앞글자를 대문자로 쓴다.
    class Person
    {
        //속성(Property)의 예시
        public string Name;
        public string Birthday;
        public string Gender;

        //메소드(Method)의 예시 (메소드 안에 메소드를 선언하는 것은 안된다.)
        public void Eat()
        {
            Console.WriteLine(Name + " 이(가) 식사를 합니다.");
        }

        public void Walk()
        {
            Console.WriteLine(Name + " 이(가) 걷습니다.");
        }

        public void Run()
        {
            Console.WriteLine(Name + " 이(가) 뜁니다.");
        }
    }
}