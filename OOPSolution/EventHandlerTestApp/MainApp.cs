using System;

namespace EventHandlerTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9 3,6,9!");

            // 클래스 객체 생성
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappend += new EventHandler(MyHandler); // 대리자에 객체 전달(체인)
                                                                      // 실행을 위해서는 MyHandler라는 메서드 필요

            for (int i = 0; i < 100; i++)
            {
                notifier.DoSomething(i); // 메서드 실행
            }
        }

        // MyHandler 메서드
        // DoSomething을 실행해줌
        private static void MyHandler(string message)
        {
            Console.Write(message);
        }
    }
}
