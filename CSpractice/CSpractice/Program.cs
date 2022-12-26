using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleGame
{
    class Machine
    {
        //형식 매개변수란?
        //함수에 형식을 지정하지 않아도 호출 시에 형식만 지정하면
        //어떤 형식이든 사용할 수 있는 매개변수이다.
        public void Driving<T>(T x)
        {
            Console.WriteLine($"x의 값 : {x}");
        }

        public T Process<T>(T x)
        {
            return x;
        }

    }

    class STL<T> where T : class
    {
        public void Push<V>(V x)
        {
            Console.WriteLine("Push : " + x);
        }

        public V Pop<V>(V x)
        {
            return x;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 일반화 프로그래밍
            /*
            //일반화 프로그래밍
            //데이터 형식에 의존하지 않고, 하나의 값이 여러 다른 데이터 타입들을
            //가질 수 있는 기술에 중점을 두어 재사용성을 높일 수 있는 프로그래밍 방법

            Machine machine = new Machine();

            machine.Driving(10);
            machine.Driving(5.8346);
            machine.Driving('W');
            machine.Driving("string");

            //형식 매개변수는 컴파일 시에 자료형을 결정한다.
            int num1 = machine.Process(300);
            float num2 = machine.Process(6.771f);
            char num3 = machine.Process('Y');
            string num4 = machine.Process("soccer");

            //형식 매개변수의 경우 박싱, 언박싱이 일어나지 않는다.
            machine.Driving(num1);
            machine.Driving(num2);
            machine.Driving(num3);
            machine.Driving(num4);

            STL<int> stack = new STL<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Pop(1);
            stack.Pop(2);
            stack.Pop(3);
            */
            #endregion

            //형식 범위 제한
            //특정 형식으로 제한할 때 사용하는 키워드

            STL<string> queue = new STL<string>();
            queue.Push("Game");

            //struct : 값 형식의 데이터만 가능하다.
            //class : 참조 형식의 데이터만 가능하다.
            //new() : 매개변수가 없는 생성자가 반드시 존재해야 가능하다.
            //상위클래스(이름) : 해당 상위 클래스의 파생 클래스여야 가능하다.
            //interface(이름) : 해당 인터페이스를 구현한 클래스여야 가능하다.



        }
    }
}