using System;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("고양이 객체 생성");
            //Cat kitty = new Cat("키티");
            //kitty.Name = "키티";
            //kitty.Age = 3;
            //kitty.Color = "하얀색";
            //kitty.Meow();

            Animal a = new Cat("네로", "하얀색");
            Cat b = a as Cat;
            a.Sleep();
            

            Cat nero = new Cat("네로");
            nero.Age = 12;
            nero.Name = "네로";
            nero.Color = "검정";
            nero.Meow();
            nero.Sleep();

            //Cat allcat = new Animal(); 은 안된다

            var list = ("Cat", "Dog", "Pig");
            Console.Write($"튜플 첫번째 : {list.Item1}");
            Console.Write($"\n튜플 두번째 : {list.Item2}");
            Console.Write($"\n튜플 세번째 : {list.Item3}");
        }
    }
}
