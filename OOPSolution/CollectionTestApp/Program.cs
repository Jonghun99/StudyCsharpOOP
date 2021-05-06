using System;
using System.Collections;

namespace CollectionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //int a = 123;
            //object obj = a; // 박싱
            //int b = (int)obj; // 언박싱

            //Console.WriteLine($"a의 값 : {a}");
            //Console.WriteLine($"obj의값 : {obj}");
            //Console.WriteLine($"b의값 : {b}");

            //string str = "문자열";
            //obj = str;

            Console.WriteLine("ArrayList 예제");

            ArrayList list = new ArrayList(); // 사이즈 지정x
            list.Add(3);
            list.Add(67);
            list.Add(1);
            list.Add(30);
            list.Add(14);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort();

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Reverse();

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(100);

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();


            list.RemoveAt(4);

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index100 = list.IndexOf(100);
            Console.WriteLine($"100의 위치 : {index100}");

            list.Add(14);

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index14 = list.IndexOf(14);
            Console.WriteLine($"14의 위치 : {index14}");

            int lstIndex14 = list.LastIndexOf(14);
            Console.WriteLine($"14의 위치 : {lstIndex14}");

            Console.WriteLine($"총 갯수 {list.Count}");
            Console.WriteLine($"리스트 마지막 값 {list[list.Count-1]}");
        }
    }
}
