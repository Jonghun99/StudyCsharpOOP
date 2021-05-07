using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp // indexer는 객체를 배열처럼 사용할수 있도록 도와줌
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        private int position = -1; // 배열의 현재 위치값

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

        // IEnumerator 메서드
        public object Current
        {
            get { return array[position]; } // 현재값 foreach에만 필요
        }
        public MyList()
        {
            array = new int[3];
        }

        // IEnumerable 메서드
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        // IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }
        // IEnumerator
        public void Reset()
        {
            position = -1;   
        }
    }
}
