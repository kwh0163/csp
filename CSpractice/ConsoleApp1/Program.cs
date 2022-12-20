using System;

namespace ConsoleGame
{
    internal class Program
    {
        class Parent
        {
            int age;
            protected int money;

            //생성자
            //클래스가 인스턴스가 생성되는 시점에서
            //자동으로 호출되는 특수한 멤버 메소드
            public Parent(string name)
            {
                Console.WriteLine(name + "클래스 생성됨");
            }

            protected void Information()
            {
                Console.WriteLine("Parent Class 입니다.");
            }


        }

        //Child 클래스가 Parent 클래스를 상속
        class Child : Parent
        {
            //생성자의 호출 순서는 상위클래스에서 하위클래스 순서로 호출
            //소멸자의 호출 순서는 하위클래스에서 상위클래스 순서로 호출

            //기본 생성자
            //생성자가 없을 때 컴파일러가 자동으로 생성해주는 생성자

            //base()
            //상위 클래스의 생성자를 호출하는 메소드
            public Child() : base("Child의 Parent")
            {
                Console.WriteLine("Child 클래스 생성됨");
            }


            //int age
            int money;
            public void Function()
            {
                //base는 상위클래스를 가리키는 포인터이다.
                //this는 자기 자신을 가리키는 포인터이다.
                base.money += 1; //상위 클래스 money 변수
                this.money = 10; //하위 클래스 money 변수
                //base 키워드와 this 키워드를 사용하지 않고 이름이 겹치는
                //멤버 변수를 호출했다면 this 포인터가 우선권을 가진다.
                Console.WriteLine("Child의 money : " + money);
                Console.WriteLine("Parent의 money : " + base.money);
            }




        }

        //메소드의 오버로딩
        //같은 이름의 메소드를 매개 변수의 자료형과 매개변수의
        //수로 구분하여 여러 개를 선언할 수 있는 기능이다.

        class Vector
        {
            public void Coordinate(int x, int y)
            {
                Console.WriteLine("int x : " + x + ", int y : " + y);
            }
            public void Coordinate(float x, float y)
            {
                Console.WriteLine("float x : " + x + ", float y : " + y);
            }

            public void Coordinate(float x, float y, float z)
            {
                Console.WriteLine("float x : " + x + ", float y : " + y + ", float z : " + z);
            }


        }



        static void Main(string[] args)
        {
            //상속
            #region 상속
            /*
            //상위 클래스의 속성을 하위클래스가
            //사용할 수 있도록 설정해주는 기능
            Parent parent = new Parent("Parent");
            Child child = new Child();
            child.Function();

            //메소드의 오버로딩
            Vector vector = new Vector();
            vector.Coordinate(10.5f, 20.5f);
            vector.Coordinate(10.5f, 20.5f, 30.5f);
            vector.Coordinate(10, 20);
            */
            #endregion



        }
    }
}