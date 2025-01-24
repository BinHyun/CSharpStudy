using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //사용 할 클래스명을 자료형으로 적은 뒤, 변수명을 적어준다.
            //그 후 new 키워드를 사용하여 초기화한다. (메모리 할당)
            /*
            Person person = new Person();
            
            person.Name = "빈현";
            person.Eat();
            */

            Cat Mycat = new Cat("김춘복");
            Cat YourCat = new Cat("김누아", 10);

        }
    }
}