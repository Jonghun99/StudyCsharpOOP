using System;

namespace LambdaTest
{
    class Program
    {
        delegate void DoSomthing(string name);
        delegate string Concatenate(string[] arr);

        static void Main(string[] args)
        {
            DoSomthing DoIt = (name) =>
            {
                Console.Write("Hello ");
                Console.WriteLine($"{name}");
            };
            string name = "Hugo";
            DoIt(name);

            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (var item in arr)
                {
                    result += item;
                }
                return result;
            };
            string[] strarr = {"아버지가", "방에", "들어가신다"};
            Console.WriteLine(concat(strarr));

            // Func : return값이 마지막
            Func<int> func1 = () => 3;

            var val = func1();
            Console.WriteLine($"val의 값은 {val}");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3 + 5 = {plus(3, 5)}");

            // Action : return값이 없음(void)
            Action<int> area = (r) =>
            {
                Console.WriteLine($"원의 넓이는 {(double)r * Math.PI}");
            };
            area(10);
        }

    }
}
