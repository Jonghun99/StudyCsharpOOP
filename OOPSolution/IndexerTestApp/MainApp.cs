using System;

namespace IndexerTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");

            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
            {
                list[i] = (i + 1);
            }

            Console.WriteLine("for문 =====>");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("foreach문 =====>");
            foreach (var item in list)  // list는 배열이 아니므로 그냥 foreach쓰는건 불가능(인덱서를 통해 만든 객체의 가짜 배열)
            {
                Console.WriteLine(item);
            }
        }
    }
}
