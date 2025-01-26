using System;

namespace ConsoleApp1
{
    class RobotClass
    {
        public void Move()
        {
            Console.WriteLine("로봇이 움직입니다.");
        }

        public void Stop()
        {
            Console.WriteLine("로봇이 잠시 멈췄습니다.");
    
        }   
    }

    class CleanRobot : RobotClass {
        /* 상속받은 class에도 Move 메소드가 있으나, 자식 class에도 Move 메소드를 만들 수 있음
         * 이게 오버라이딩의 개념. 오버로드는 같은 메소드 이나 인자값이 다를 경우를 말하지만
         * 오버라이딩은 인자값도 똑같고, 메소드의 명도 같은 경우이며 이걸 재정의 라고도 함
         */
        public void Move()
        {
            Console.WriteLine("청소로봇이 움직입니다.");
        }


        public void Clean()
        {
            Console.WriteLine("청소를 시작 합니다.");
        }
    }
}