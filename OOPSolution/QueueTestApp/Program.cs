using System;
using System.Collections;

namespace QueueTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 스택큐 로직 영역

            Queue que = new Queue();

            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count>0)
            {
                Console.Write(que.Dequeue() + "\t");
            }
            Console.WriteLine();

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()}\t");
            }
            Console.WriteLine();

            #endregion

            Hashtable dictionary = new Hashtable();
            dictionary["book"] = "책";
            dictionary["cook"] = "요리사";
            dictionary["tweet"] = "지저귀다";
            dictionary["whale"] = "고래";

            Console.WriteLine(dictionary["tweet"]);
        }
    }
}
