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

            /*
            Cat Mycat = new Cat("김누아");
            Mycat.Name = "김춘복";
            Console.WriteLine("고양이의 이름은 " + Mycat.Name + " 입니다.");
            //Cat YourCat = new Cat("김누아", 10);
            */

            /*
            CleanRobot cleanRobot = new CleanRobot();
            cleanRobot.Move();
            cleanRobot.Stop();
            cleanRobot.Clean();
            */

            PrivateThisClass pt = new PrivateThisClass();
            pt.SetName("김빈현");
            Console.WriteLine("설정한 이름은 " + pt.GetName() + " 입니다.");
        }
    }
}