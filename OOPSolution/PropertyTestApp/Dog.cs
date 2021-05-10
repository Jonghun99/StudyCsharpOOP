using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        
        private int age;

        //public int weight;

        //public void Weight(int weight)
        //{
        //    this.weight = weight;
        //}

        //private string name;

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        this.name = value;
        //    }
        //}

        public string Name { get; set; } = "누렁이"; // 값을 정하는 것만 하고싶을때
        public string Color { get; set; } = "노랑색"; // 기본값을 넣고싶을때
        public int Age // get, set으로 값을 한정하고 싶을때
        {
            get
            {
                return age;
            }

            // 람다식으로?
            // get => age;

            set
            {
                if (value < 0)
                {
                    this.age = 1;
                }
                else if(value > 15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
            }

            // 람다식 불가능
        }

        //public string GetName() // 값을 사용
        //{
        //    return this.name;
        //}
        //public void SetAge(string name) // 값을 설정
        //{
        //    this.name = name;
        //}

        //public string GetAge() // 값을 사용
        //{
        //    return $"{this.age}세";
        //}

        //public void SetAge(int age) // 값을 설정
        //{
        //    if (age < 0)
        //    {
        //        this.age = 1;
        //    }
        //    else if (age > 15)
        //    {
        //        this.age = 15;
        //    }
        //    else
        //    {
        //        this.age = age;
        //    }
        
    }
}
