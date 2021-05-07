using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작!");

            int[] array = new int[5];
            for (int i = 0; i <= 5; i++)
            {
                try
                {
                    array[i] = (i + 1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} 관리자에게 문의하세요 : Main(16~)");
                }
            }

            Console.WriteLine("다른 로직 수행");
            //...
            int[] list = { 107, 108, 109 };

            try
            {
                var result = list[1] / 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                // IndexOutOfRange예외시 다른일 처리
                Console.WriteLine("IndexOutOfRangeException 이후 처리!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("DivideByZeroException 이후 처리!");
            }

            finally
            {
                Console.WriteLine("Finally, 언제든지 실행됨");
            }

            Console.WriteLine("프로그램 종료");
        }
    }
}
