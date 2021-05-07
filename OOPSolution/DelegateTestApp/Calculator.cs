using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestApp
{
    delegate int CalcDelegate(int a, int b); // 대리자 선언 (대신 처리해야 하므로 타입, 갯수 동일)
                                             // 클릭 하나로 여러가지 일을 할수 있는것 처럼 callBack하나가 각기다른 메소드를 호출
    class Calculator
    {
        public int Plus(int a, int b) { return a + b; }
        public int Minus(int a, int b) { return a - b; }
        public int Multiple(int a, int b) { return a * b; }
        public int Divide(int a, int b) { return a / b; }
    }
}
