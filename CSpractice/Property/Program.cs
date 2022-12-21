using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Property
{
    class Unit
    {
        public int Data
        {
            set
            {
                if (value > 18)
                {
                    Console.WriteLine("error");
                    return;
                }
                Data = value;
            }
        }

        //자동구현 프로퍼티
        //자동 구현 프로퍼티는 선언을 했을 때 컴파일러가 자동으로 private필드를 생성함

        public int Health
        {
            set; get;

        } = 200;

        public int Attack
        {
            get;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 프로퍼티
            /*
            Unit factory = new Unit();
            factory.Data = 100;
            factory.Health = 100;

            Console.WriteLine("Unit의 Data : " + factory.Data);
            Console.WriteLine("Unit의 Health : " + factory.Health);
            */
            #endregion

            //String Builder
            StringBuilder score = new StringBuilder("100");

            //Replace
            //첫번째 매개변수에 있는 문자열을 두번째 매개변수에 있는
            //문자열로 변경하는 메소드이다.
            score.Replace("100", "200");

            Console.WriteLine("score 변수의 값 : " + score);

            //Append
            score.Append("의 값을 가지고 있습니다.");

            Console.WriteLine("score 변수의 값 : " + score);


            //가변 -> 객체가 인스턴스된 후에 변할 수 있는 객체
            //불변 -> 객체가 인스턴스된 후에 변할 수 없는 객체

            string name = "KIM";
            name = "LEE";





            //OOP 4대 특징
            //1. 추상화
            //2. 상속
            //3. 다형성
            //4. 캡슐화

        }
    }

}