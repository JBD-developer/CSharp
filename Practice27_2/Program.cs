using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice27_2
{
    delegate int Compare<T>(T a, T b);
    class Program
    {
        static int AscendCompate<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }
        static int DeScendCompare<T>(T a , T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }
        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i = 0;
            int j = 0;
            T temp;
            for (i = 0; i < DataSet.Length-1; i++)
            {
                for (j = 0 ; j < DataSet.Length-(i+1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j+1]) >0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp; 
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 34, 5, 56, 7 };
            Console.WriteLine("Sorting Ascending");
            BubbleSort<int>(array, new Compare<int>(AscendCompate));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }

            string[] array2 = { "C#", "JAVA", "PYTHON", "JAVASCRIPT", "HTML"};
            
            Console.WriteLine("Sorting Descending");

            BubbleSort<string>(array2, new Compare<string>(DeScendCompare));
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{array2[i]}");
            }
        }
    }
}
