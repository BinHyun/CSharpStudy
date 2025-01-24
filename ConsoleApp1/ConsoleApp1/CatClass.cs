using System;

namespace ConsoleApp1
{
    //클래스와 메소드의 이름이 동일한 경우, 별도의 호출 없어도
    //자동으로 메소드가 호출 된다.
    class Cat
    {
        public string Name;
        public int Age;

        public Cat(string name)
        {
            Name = name;
            Console.WriteLine("고양이의 이름은 " + Name + "입니다.");
           

        }

        //오버로딩 메소드는 다른 메소드 똑같지만, 받는 인자를
        //추가 하거나 제외해서 사용 할 수 있는 메소드 이다.
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("고양이의 이름은 " + Name + "입니다.");
            Console.WriteLine("고양이의 나이는 " + Age + "입니다.");

        }

        //소멸자(일반적으론 자주 사용되지 않음)
        ~Cat()
        {
            Console.WriteLine("해당 Class를 종료 합니다.");
        }
    }
}