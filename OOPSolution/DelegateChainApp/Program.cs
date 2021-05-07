using System;

namespace DelegateChainApp
{
    delegate int Calculate(int a, int b); // 계산 대리자를 선언(for 익명메서드)

    class Program
    {
        static void Main(string[] args)
        {
            #region
            // 클래스 객체 생성
            FireStation station = new FireStation();
            // 대리자 생성
            ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
            fireHouse += new ThereIsAFire(station.ShoutOut); // 대리자 체인
            fireHouse += new ThereIsAFire(station.Escape);   // 대리자 체인
            // 대리자 실행
            fireHouse("우리집");

            // 대리자 생성
            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.Escape);
            // 대리자 실행
            fireWoorim("우림라이온스밸리A");
            Console.WriteLine();
            #endregion

            // 익명메서드
            // 한번 부르고 실행하면 사라짐

            // 익명메서드 정의
            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            // 실행
            Console.WriteLine($"a + b = {calc(3,5)}");

        }
    }
}
