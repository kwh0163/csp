using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpractice
{
    class Solution
    {
        public void Function()
        {
            Console.WriteLine("Function");
        }

        public static void Post()
        {
            Console.WriteLine("Static Post");
        }

        public int Calculator()
        {
            //반환하는 메소드의 자료형과 반환하는 값의 자료형이 일치해야 한다.
            return 0;
        }

        public void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

    }

    internal class class3
    {
        #region 박싱
        /*
        //박싱(boxing)

        //값 형식을 참조 형식으로 변환해주는 과정

        int value = 10;

        //암묵적으로 형 변환됨

        //object가 값 타입보다 상위의 자료형이기 때문에
        //암묵적으로 형 변환이 가능하다.
        object obj = value;

        obj = 300;

        //박싱을 하는 과정에서 추가적인 메모리가 발생한다.
        Console.WriteLine("obj의 값 : " + obj);
        Console.WriteLine("value의 값 : " + value);
        */
        #endregion

        #region 언박싱
        /*
        //언박싱(UnBoxing)
        //참조 타입을 값 타입으로 변환하는 과정이다.

        //data 변수가 값 타입이므로, obj 참조 타입보다
        //하위 자료형이기 때문에 명시적으로 형 변환을 해줘야 한다.
        int data = (int)obj;

        //언박싱 변환 시 스택메모리에 언박싱된 무명객체가 생성되며
        //이 무명객체를 다시 해당 객체에 대입하는 원리이다.
        Console.WriteLine("data의 값 : " + data);

        int [] dataTable = new object[5];
        dataTable[0] = 10;
        dataTable[1] = "Sword";
        dataTable[2] = 36.5f;
        dataTable[3] = 'A';
        dataTable[4] = true;
        */
        #endregion

        /*
        Solution.Post();

        int value1 = 10;
        int value2 = 20;

        Solution solution = new Solution();
        solution.Function();
        solution.Swap(value1, value2);
        Console.WriteLine("value1 : " + value1 + ", value2 : " + value2);
        Console.WriteLine(solution.Calculator());
        */

    }
}
