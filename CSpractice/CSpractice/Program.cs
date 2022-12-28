using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleGame
{

    class Shop
    {
        virtual public void Punchase()
        {
            Console.WriteLine("구매");
        }
        virtual public void Sale()
        {
            Console.WriteLine("판매");
        }
    }

    class Equipment : Shop
    {
        public override void Punchase()
        {
            Console.WriteLine("장비 구매");
        }

        public override void Sale()
        {
            Console.WriteLine("장비 판매");
        }

    }

    class CashShop : Shop
    {
        public override void Punchase()
        {
            Console.WriteLine("캐쉬 구매");
        }

        public sealed override void Sale()
        {
            Console.WriteLine("캐쉬 판매");
        }
    }

    class EventShop : CashShop
    {
        public override void Punchase()
        {
            Console.WriteLine("이벤트 구매");
        }

        /*
        public override void Sale()
        {
            Console.WriteLine("캐쉬 판매");
        }
        */

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //sealed
            //클래스 또는 메소드가 다른 클래스에서 
            //상속되지 않도록 막아주는 키워드이다.

            EventShop eventshop = new EventShop();
            eventshop.Punchase();
            eventshop.Sale();

        }
    }
}