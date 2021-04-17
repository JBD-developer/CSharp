using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice22_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] iArray = new int[4, 3, 2]
            {
                { { 0, 0 }, { 0, 1 }, { 0, 2 } },
                { { 1, 0 }, { 1, 1 }, { 1, 2 } },
                { { 2, 0 }, { 2, 1 }, { 2, 2 } },
                { { 3, 0 }, { 3, 1 }, { 3, 2 } }
            };
    
            for(int i=0; i<iArray.GetLength(0); i++)
            {
                for(int j=0; j<iArray.GetLength(1); j++)
                {
                 
                    Console.Write("{ ");
                    
                    for (int k = 0; k < iArray.GetLength(2); k++)
                    {
                        Console.Write($"{iArray[i, j, k]} ");
                    }
                    Console.Write(" } ");
                }
                Console.WriteLine();
            }
        }
    }
}
