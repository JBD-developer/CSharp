using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice25
{
    //Generic Progeramming 
    //특수한 개념으로부터 공통된 개념을 찾아 묶는 것을 Generalization이라고 한다 
    //Generic Method는 이름처럼 Data Type을 일반화한 Method이다 
    //
    class Program
    {
        static void CopyArray<T>(T[]source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }

        }
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5, 6 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach(int element in target)
            {
                Console.WriteLine($"element : {element}");
            }

            string[] source2 = { "One", "Two", "Three", "Four", "Five" };
            string[] target2 = new string[source2.Length];

            CopyArray<string>(source2, target2);

            foreach(string element in target2)
            {
                Console.WriteLine($"element : {element}");
            }
        }
    }
}
