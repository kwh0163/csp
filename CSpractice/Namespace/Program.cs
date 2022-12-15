using System;
using OtherGame; //namespace 사용

namespace OtherGame
{
    class Data
    {
        public int value = 100;
    }
}

namespace Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach
            /*
            int[] item = new int[5];
            for(int i = 0; i<5; i++)
            {
                item[i] = i;
            }

            //배열, 리스트
            //데이터를 읽어올 때 사용
            foreach(int element in item)
            {
                //foreach문 내부에서는 값을 변경할 수 없다.
                //emelent = 100;
                Console.WriteLine(element);
            }
            */
            #endregion

            #region namespace
            /*
            //이름 공간(namespace)란
            //내부 식별자에 범위를 제공해주는 선언적인 영역이다.
            Data data = new Data();
            data.value = 100;
            Console.WriteLine("OtherGame의 value : " + data.value);

            //같은 이름의 변수를 동시에 선언했기 때문에 컴파일 에러가 난다.
            int value = 10;
            Console.WriteLine("ConsoleGame의 vlaue : " + value);
            */
            #endregion
        }
    }
}