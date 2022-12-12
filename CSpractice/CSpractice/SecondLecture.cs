using System;


public class SecondLecture
{
    class Monster
    {
        public int attack;
        public string name;

        public void Defence()
        {
            Console.WriteLine("방어");
        }
    }

    public SecondLecture()
    {
        //값 타입
        //변수의 선언과 동시에 값을 할당할 수 있으며 스택 메모리에 생성됨

        //참조 타입
        /*
        //new 키워드를 사용하여 객체를 초기화한 수 힙에 할당된
        //메모리를 스택에서 참조하여 사용하는 타입이다.

        int value = 10;

        value = 20;

        string name = "woohap";
        //int 자료형을 가진 변수를 한 공간에 방 형태로 5개 저장하는 구조
        int [] array = new int[5];

        name = "kim";

        Monster monster;
        monster.attack = 10;
        monster.name = "Goblin";
        monster.Defence();

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        Console.WriteLine(name);
        Console.WriteLine(array[0]);
        Console.WriteLine(array[1]);
        Console.WriteLine(array[2]); 
        Console.WriteLine(array[3]);
        Console.WriteLine(array[4]);
        */
    }
}