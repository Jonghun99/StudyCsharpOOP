using System;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("대성마이맥 수학점수");
            //int[] scores = new int[] { 80, 74, 81, 94, 100 }
            int[] scores = { 80, 74, 81, 94, 100 }; // 가장 간단한 배열 초기화 방법
            //scores[0] = 80;
            //scores[1] = 74;
            //scores[2] = 81;
            //scores[3] = 94;
            //scores[4] = 100;

            int sum = 0;
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    sum += scores[i];
            //}

            foreach (var score in scores)
            {
                sum += score;
            }

            float average = (float) sum / scores.Length;

            Console.WriteLine($"수학점수 총합 : {sum}, 평균 : {average}");
        }
    }
}
