using System;

namespace ConsoleApp1
{
    class ArrayClass
    {
        public void Array1()
        {
            //배열의 선언
            //[] 배열 키워드 앞에 배열의 데이터 형을 적어준다.
            //그 후 배열의 이름명을 붙여 준다.
            int[] array1 = new int[3];
            
            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;

            Console.WriteLine("array1 ==> " + array1);
        }

        public void Array2()
        {
            int[] array2 = new int[] {1,2,3};

            Console.WriteLine("array2 ==> " + array2);
        }

        public void Array3()
        {
            int[] array3 = { 4, 5, 6 };

            Console.WriteLine("array3 ==> " + array3);
        }

        public void Array4()
        {
            int[] array4 = new int[100];

            for (var i = 0; i < 100; i++)
            {
                array4[i] = i;

                Console.WriteLine("array4 의 " + i + "번째 값 : " + i); 
            }
        }
    }
}