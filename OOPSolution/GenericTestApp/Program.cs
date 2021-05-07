using System;

namespace GenericTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int배열을 int배열에 복사
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length]; // 5개짜리 int배열 { 0, 0, 0, 0, 0 }

            // 복사전
            Console.WriteLine("복사전 targetInt값 =====>");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            //복사후
            Console.WriteLine("복사후 targetInt값 =====>");
            CopyArray(sourceInt, targetInt);
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            // float배열을 float배열에 복사
            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];

            // 복사전
            Console.WriteLine("복사전 targetFloat값 =====>");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            //복사후
            Console.WriteLine("복사후 targetFloat값 =====>");
            CopyArray(sourceFloat, targetFloat);
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            // string배열을 string배열에 복사
            string[] sourceString = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] targetString = new string[sourceString.Length];

            // 복사전
            Console.WriteLine("복사전 targetString값 =====>");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            //복사후
            Console.WriteLine("복사후 targetString값 =====>");
            CopyArray(sourceString, targetString);
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        private static void CopyArray(int[] source, int[] target) // static으로 만들어 주어야함
                                                                  // static 메소드안에 sourceInt, targetInt가 있으므로
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

        private static void CopyArray(float[] source, float[] target) // 메서드 오버로딩
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

        private static void CopyArray(string[] source, string[] target) // 메서드 오버로딩
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
    }
}
