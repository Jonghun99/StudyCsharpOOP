using System;

namespace SelfStudy
{
    class Cat
    {
        private string Name;
        public string Color;
        private int Weight;

        public string _Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public int _Weight { get { return Weight; }}

        public Cat(string Name, string Color, int Weight)
        {
            this.Name = Name;
            this.Color = Color;
        }

        public Cat(string Name, string Color)
        {
            this.Name = Name;
            this.Color = Color;
        }

        public void Meow()
        {
            Console.WriteLine($"{Color} {Name} : 야옹");
        }

        public void Meow(int Weight)
        {
            this.Weight = Weight;
            Console.WriteLine($"{Color} {Name} {Weight}kg : 야옹");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat Kitty = new Cat("야옹이", "노랑색");
            Kitty.Meow();

            Cat Kitty2 = new Cat("멍멍이", "검정색");
            string name = Kitty2._Name;
            Kitty2.Color = "검정색";
            Kitty2.Meow();

            Cat Kitty3 = new Cat("", "하얀색");
            Kitty3._Name = "나옹";
            Kitty3.Meow(68);
            Console.WriteLine(Kitty3._Weight + "kg 이라고??"); 
        }
    }
}
