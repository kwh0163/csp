using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleGame
{
    //인터페이스
    //클래스들이 구현해야하는 동작을 지정하는 용도로 사용되는 추상 자료형이다.
    interface IMonitor
    {
        //인터페이스는 메소드를 선언만 할 수 있다.
        void Power();
    }

    interface IMouse 
    {
        //인터페이스는 멤버 변수를 가질 수 없다.
        //int value;
        //인터페이스는 프로퍼티를 가질 수 있다.
        //int Damage {set;get;}

        void Click();
    }

    class Computer : IMonitor, IMouse
    {
        public void Click()
        {
            Console.WriteLine("마우스 클릭");
        }

        public void Power()
        {
            Console.WriteLine("모니터 전원 on");
        }
    }

    interface IObject
    {
        void HealthManager();
    }

    class Player : IObject
    {
        public int hp;
        public void HealthManager()
        {
            hp -= 50;
            Console.WriteLine("Player의 체력이 감소되었습니다. hp : " + hp);
        }
    }

    class Monster : IObject
    {
        public int hp;

        public void HealthManager()
        {
            hp -= 25;
            Console.WriteLine("Monster의 체력이 감소되었습니다. hp : " + hp);
        }
    }

    class NPC : IObject
    {
        public int hp;
        public void HealthManager()
        {
            hp -= 70;
            Console.WriteLine("NPC의 체력이 감소되었습니다. hp : " + hp);
        }
    }

    class Damage
    {
        public void DecreaseHP(IObject iobject)
        {
            iobject.HealthManager();
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인터페이스
            /*
            Computer computer = new Computer();
            computer.Power();
            computer.Click();

            //인터페이스는 객체로 인스턴스 할 수 없다.
            //IMouse mouse = new IMouse();

            IMouse lg = new Computer();
            lg.Click();
            */
            #endregion


            Monster goblin = new Monster();
            goblin.hp = 100;
            Monster slime = new Monster();
            Player player = new Player();
            player.hp = 100;

            Damage damage = new Damage();
            damage.DecreaseHP(goblin);
            damage.DecreaseHP(player);



        }
    }
}