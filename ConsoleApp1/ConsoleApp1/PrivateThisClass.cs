using System;

namespace ConsoleApp1
{
    class PrivateThisClass
    {
        /*
         * private 경우 외부에서 호출할수 없다.
        */
        private string _name;
        /*
         * public의 경우 외부에서 . 연산자로 호출이 가능하다.
        */
        public void SetName(string _name)
        {
            this._name = _name;
            Console.WriteLine("전달 받은 이름은 " + this._name + " 입니다.");
        }

        public string GetName()
        {
            return this._name;
        }
    }
}