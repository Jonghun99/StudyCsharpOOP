using System;
using System.Threading;

namespace ThreadLockTestApp
{
    class Counter
    {
        private int counter = 1000;

        private object thislock = new object();

        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread th = new Thread(UnsafeCalc);
                th.Start();
            }
        }

        public void UnsafeCalc()
        {
            lock (thislock)
            {
                counter++;
                Thread.Sleep(1);
                Console.WriteLine(counter);
            }

            //lock을 안했을때(동기화가 안되어 자원에 마음대로 접근)
            //counter++;

            //for (int i = 0; i < counter; i++)
            //    for (int j = 0; j < counter; j++)
            //    {
            //        // Do Something
            //    }
            //Console.WriteLine(counter);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Run();
        }
    }
}
