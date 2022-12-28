using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //콜레션
            //데이터를 저장하는 자료구조와 데이터를 처리하는
            //알고리즘을 구조화하여 클래스로 나타낸 형태이다.

            #region List
            /*
            //List
            List<int> list = new List<int>();

            //Add()
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //Insert(,)
            list.Insert(1, 66);

            //Remove()
            list.Remove(3);

            //RemoveAt()
            list.RemoveAt(1);

            int listSize = list.Count;

            foreach (var ele in list)
            {
                Console.WriteLine(ele);
            }
            */
            #endregion

            #region ArrayList
            /*
            //ArrayList  --  vector랑 비슷
            ArrayList arrayList = new ArrayList();

            //Add()
            arrayList.Add(1);
            arrayList.Add(64.5f);
            arrayList.Add('V');
            arrayList.Add("under");
            arrayList.Add(false);

            //Insert(,)
            //저장하고 싶은 index, 저장할 값
            arrayList.Insert(1,33.987);


            //Remove()
            arrayList.Remove(64.5f);

            //RemoveAt()
            arrayList.RemoveAt(0);

            //size
            int size = arrayList.Count;

            foreach(var ele in arrayList)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("arrayList의 크기 : " + size);
            */
            #endregion

            #region Dictionary
            /*
            //Dictionary  --  hash 함수랑 비슷
            Dictionary<string, int> item = new Dictionary<string, int>();

            //Add()
            //key(string), value(int)
            item.Add("Sword", 10000);
            item.Add("Hat", 1000);
            item.Add("Shoes", 5000);
            item.Add("Glove", 3000);

            //Remove()
            item.Remove("Shoes");

            //Key 정보 탐색
            bool findKey = item.ContainsKey("Hat");

            //Value 정보 탐색
            bool findValue = item.ContainsValue(1000);

            Console.WriteLine(item["Sword"]);
            */
            #endregion

            #region Stack
            /*
            //Stack
            Stack<string> stack = new Stack<string>();

            //Push
            stack.Push("window1");
            stack.Push("window2");
            stack.Push("window3");

            //Pop
            stack.Pop();

            //Count
            int count = stack.Count;
            Console.WriteLine("stack의 count : " + count);

            foreach(var ele in stack)
            {
                Console.WriteLine(ele);
            }
            */
            #endregion

            #region Queue
            /*
            //Queue
            Queue<char> queue = new Queue<char>();

            //Enqueue
            queue.Enqueue('A');
            queue.Enqueue('B');
            queue.Enqueue('C');
            queue.Enqueue('D');

            //Dequeue
            queue.Dequeue();

            foreach(var ele in queue)
            {
                Console.WriteLine(ele);
            }
            */
            #endregion
        }
    }
}