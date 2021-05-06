using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("강아지객체 생성");
            Dog beakgoo = new Dog();
            beakgoo.Age = 250000;
            beakgoo.Name = "백구";

            Console.WriteLine($"{beakgoo.Name}의 나이는 {beakgoo.Age}세");

            Dog streetdog = new Dog();
            Console.WriteLine($"{streetdog.Name}의 색깔은 {streetdog.Color}");

            Dog dog1 = new() // 간결하게 초기화 하는 방식
            {
                Name = "깜장이",
                Age = 5,
                Color = "검정색"
            };

            var myInstance = new { Name = "하양이", Color = "하얀색" };
            Console.WriteLine(myInstance.Name);
            Console.WriteLine(myInstance.Color);


            //Console.WriteLine($"백구의 나이는 {beakgoo.GetAge()}");
        }
    }
}
