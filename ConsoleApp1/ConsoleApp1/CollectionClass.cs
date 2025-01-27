using System;
using System.Collections;

namespace ConsoleApp1
{
    class CollectionClass
    {
        //자바스크립트의 List와 유사한 개념
        //Array는 길이가 정해져 있으나, ArrayList는 가변적
        public ArrayList ArrayList()
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("Hello");
            al.Add(true);

            return al;
        }

        public Hashtable Hashtable()
        {
            Hashtable ht = new Hashtable();

            ht["apple"] = "사과";
            ht["banana"] = "바나나";
            ht["orange"] = "오렌지";

            return ht;
        }
    }
}