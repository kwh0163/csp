using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleGame
{
    delegate void Delegate();

    class IPhone
    {
        public int price;
        public int version;

        public IPhone(int _price, int _version)
        {
            this.price = _price;
            this.version = _version;
        }

    }

    class Galaxy 
    {
        public int price;
        public int version;

        public Galaxy DeepCopy()
        {
            Galaxy newGalaxy = new Galaxy();
            newGalaxy.price = this.price;
            newGalaxy.version = this.version;

            return newGalaxy;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 무명 형식
            /*
            //무명 형식
            //이름이 없는 데이터 형식
            //임시 변수가 필요할 때 사용하는 형식 -- 임시변수 : 임시로 생성해서 사용 후, 더이상 사용되지 않는 변수

            var temp = new { age = 40, name = "Kim" };

            //무명 형식으로 생성된 인스턴스는 읽기 전용이기 때문에 값을 변경할 수 없다.
            //temp.age = 30 <-(X)

            Console.WriteLine("temp의 age : " + temp.age + "\ntemp의 name : "+temp.name);
            */
            #endregion

            #region 무명 메소드
            /*
            //무명 메소드
            //단순한 명령어 구문으로 구성된 메소드를 정의하지 않고
            //델리게이트를 사용하여 1회용으로 사용하는 메소드
            Delegate value;

            value = () => { Console.WriteLine("로그인 실패"); };
            value += () => { Console.WriteLine("오류"); };
            value();
            value();
            value();
            */
            #endregion

            #region 얕은 복사
            /*
            //얕은 복사
            //객체를 복사할 때 주소값을 복사하여 같은 메모리를 가리키는 복사
            IPhone se1 = new IPhone(20000,1);
            IPhone se2 = se1;
            
            se2.version = 2;
            se2.price = 100000;

            Console.WriteLine("se1의 버전 : " + se1.version);
            Console.WriteLine("se1의 가격 : " + se1.price);
            Console.WriteLine("se2의 버전 : " + se2.version);
            Console.WriteLine("se2의 가격 : " + se2.price);
            */
            #endregion

            //깊은 복사
            //객체를 복사할 때, 참조값이 아닌 인스턴스 자체를
            //새로 복사하여 서로 다른 메모리를 생성하는 복사

            Galaxy S1 = new Galaxy();
            S1.price = 20000;
            S1.version = 1;

            Galaxy S2 = S1.DeepCopy();
            S2.price = 100000;


            Console.WriteLine("S1 version : " + S1.version);
            Console.WriteLine("S1 price : " + S1.price);
            Console.WriteLine("S2 version : " + S2.version);
            Console.WriteLine("S2 price : " + S2.price);

        }
    }
}