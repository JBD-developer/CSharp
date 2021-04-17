using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice22_4
{
    //Multi-dimensional Array
    //2차원 배열은 2개의 차원(세로 + 가로)으로 원소를 배치하는 2차원 배열이다 
    //1차원 배열을 요소로 갖는 배열 
    // 데이터 형식[,] 배열 이름 = new 데이터 형식(2차원 길이, 1차원 길이) 
    class Program

    {
        static void Main(string[] args)
        {
            int[,] iArray = new int[2, 3];
            iArray[0, 0] = 1;
            iArray[0, 1] = 2;
            iArray[0, 2] = 3;
            iArray[1, 0] = 4;
            iArray[1, 1] = 5;
            iArray[1, 2] = 6;

            int[,] iArray2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6, } };

            for(int i=0; i< iArray2.GetLength(0); i++)
            {
                for(int j=0; j< iArray2.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}] : {iArray2[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] iArray3 = new int[,] { { 7, 8, 9 }, { 10, 11, 12 } };

            for(int i=0; i<iArray3.GetLength(0); i++)
            {
                for(int j=0; j<iArray3.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}] {iArray3[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            string[,] sArray = new string[,] { { "Java", "Spring", "JSP" }, { "C#", "ASP", "WindowsForms" } };

            for(int i=0; i<sArray.GetLength(0); i++)
            {
                for(int j=0; j<sArray.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}]  {sArray[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
