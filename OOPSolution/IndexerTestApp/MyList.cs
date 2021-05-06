using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp // indexer는 객체를 배열처럼 사용할수 있도록 도와줌
{
    class MyList
    {
        private int[] array;

        public int this [int index] // == MyList[i] == array[i]
        {
            get 
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length) // index = 5, array.Length = 3
                {
                    System.Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get 
            {
                return array.Length;
            }
        }

        public MyList()
        {
            array = new int[3];
        }
    }
}
