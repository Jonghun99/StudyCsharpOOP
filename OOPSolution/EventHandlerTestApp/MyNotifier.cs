using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTestApp
{
    delegate void EventHandler(string message); // 대리자 선언asd

    // 클래스 생성
    class MyNotifier
    {
        public event EventHandler SomethingHappend; // 대리자의 변수 생성(이벤트 생성)

        public void DoSomething(int number) // 메소드 생성
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappend($"짝!\t"); // 이벤트에 메소드 결과값 전달
            }
            else
            {
                SomethingHappend($"{number}\t");
            }
        }
    }
}
