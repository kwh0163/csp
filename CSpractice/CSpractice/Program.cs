using System;

namespace ConsoleGame{
    class Function{
        public void Change(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //out 키워드
        //out 매개변수의 메소드 내부에서 값을 무조건 초기화해야 한다.
        public void Output(out int x)
        {
            //out은 함수 내부에서 함수 외부로 전달하는 방향이다.
            x = 1000;
        }

        //in 키워드
        public void ItemList(in int x)
        {
            //in은 메소드 내부에서 값을 수정할 수 없다.
            //x = 500;
            Console.WriteLine("x : " + x);
        }

        //params 키워드
        public void StatList(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("list["+ i+"]"+" : "+list[i]);
            }
        }
    }

    internal class Program{
        static void Main(string[] args){
            #region 매개 변수 한정자
            /*
            int value1 = 10;
            int value2 = 20;

            int data;
            int item = 10;
            
            //ref 키워드
            //매개 변수가 참조로 전달할 수 있고, 호출된 메소드로 읽거나
            //쓸 수 있는 한정자이다.
            Function function = new Function();

            //ref 키워드는 인수로 전달하는 변수의 값이 초기화가 되어 있어야 한다.
            function.Change(ref value1, ref value2);

            Console.WriteLine("value1 : " + value1);
            Console.WriteLine("value2 : " + value2);

            //out 키워드 (출력용 매개변수)
            //매개 변수가 참조로 전달할 수 있고, 호출된 메소드에 의해서
            //기록되도록 지정하는 한정자이다.
            function.Output(out data);
            Console.WriteLine("data : " + data);

            //in 키워드
            //매개 변수를 참조로 전달할 수 있지만, 호출된 메소드에서
            //읽기만 가능한 한정자이다.
            function.ItemList(in item);
            Console.WriteLine("item : " + item);

            //params 키워드
            //매개 변수가 가변 개수의 인수를 사용할 수 있도록 지정해주는 한정자이다.
            function.StatList(1, 2, 3, 4, 5);
            //인수를 전달하지 않으면 배열의 길이는 0으로 설정됨
            function.StatList();
            */
            #endregion

            var name = "kimwoohyup";
            var age = 10;
            var health = 100.0;
            var alphabet = 'A';

            Console.WriteLine("name의 값 : " + name);
            Console.WriteLine("age의 값 : " + age);
            Console.WriteLine("health의 값 : " + health);
            Console.WriteLine("alphabet의 값 : " + alphabet);

        }
    }
}