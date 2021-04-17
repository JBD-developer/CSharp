using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Practice22_3
{
    class Program
    {
        //Array Slice
        
        static void PrintArray(Array array)
        {
            foreach(var e in array)
            {
                Console.WriteLine($"e :{e}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            char[] cArray = new char['Z'-'A' + 1 ];

            for(int i=0; i<cArray.Length; i++)
            {
                cArray[i] = (char)('A' + i);
            }

            PrintArray(cArray);
           
        }
    }
}
