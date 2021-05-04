using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
        public string Name { get ; set; }

        public string Color;

        public int Age { get; set; }

        public Cat()
        {
        }

        public Cat(string Name, string Color)
        {
            this.Name = Name;
            this.Color = Color;
        }

        public Cat(string Name)
        {
            this.Name = Name;
        }

        public Cat(string Name, string Color,int Age)
        {
            this.Name = Name;
            this.Color = Color;
            this.Age = Age;
        }

        public void Meow()
        {
            Console.WriteLine("{0}, 야옹!", this.Name);
        }
        public override void Sleep()
        {
            //base.Sleep();
            Console.WriteLine($"{this.Color} 고양이 {this.Name}이(가) 잡니다");
        }
    }
}
