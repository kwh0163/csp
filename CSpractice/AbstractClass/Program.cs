using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace AbstractClass
{
    abstract class Equipment
    {
        abstract public void Effect();

        public void Durability(int value)
        {
            Console.WriteLine("내구도 : " + value);
        }
    }

    delegate void CallBack();

    internal class Program
    {
        static void Button(CallBack callBack)
        {
            callBack();
        }

        static void UserInterFace()
        {
            Console.WriteLine("Characer stat Window");
        }

        class Weapon : Equipment
        {
            public override void Effect()
            {
                Console.WriteLine("공격력 증가");
            }

            new public void Durability(int value)
            {
                Console.WriteLine("내구도 : " + value);
            }
        }

        class Shield : Equipment
        {
            public override void Effect()
            {
                Console.WriteLine("방어력 증가");
            }

        }


        static void Main(string[] args)
        {
            #region 추상 클래스
            /*
            //추상 클래스
            //하나이상의 추상 메소드를 포함하고 있는 클래스
            Weapon weapon = new Weapon();
            weapon.Durability(100);
            weapon.Effect();

            Shield shield = new Shield();
            shield.Effect();
            */
            #endregion

            #region 입력
            //입력
            /*
            string name;
            
            name = Console.ReadLine();

            Console.WriteLine(name);

            //string.Format()
            //지정한 형식에 따라 개체의 값을 문자열로 변환하여
            //다른 문자열에 삽입하는 메소드.

            //{첨자, 맞춤 : 서식문자열}

            string data = string.Format("{0}, {1}, {2}", 10, 5.59, 'A');
            Console.WriteLine(data);
            
            //문자열 보간
            int damage = 10;
            int critical = 33;

            Console.WriteLine($"{damage} + {critical} = {damage + critical}");

            //콜백 함수
            //다른 함수의 인수로써 넘겨진 후 특정 이벤트에 의해 호출되는 함수

            //시스템에 의해 호출 시점이 결정되는 함수
            Button(UserInterFace);
            */
            #endregion

        }
    }
}