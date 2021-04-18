using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice22_6
{
    //Jagged Array 
    //가변배열은 다양한 길의의 배열을 요소로 갖는 다차원 배열 
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };

            foreach( int [] array in jagged)
            {
                Console.Write($"Length : {array.Length}, ");
                Console.Write(" {");
                foreach(int value in array)
                {
                    Console.Write($"{value} ");
                }
                Console.Write("} ");
                Console.WriteLine();

            }

            char[][] jagged2 = new char[4][];
            jagged2[0] = new char[4] { 'a', 'b', 'c', 'd'};
            jagged2[1] = new char[] { 'e', 'f', 'g' ,'h' };
            jagged2[2] = new char[] { 'i', 'j', 'k', 'l' };
            jagged2[3] = new char[] { 'm', 'n', 'o', 'p' };

            foreach(char [] array in jagged2)
            {
                Console.Write($"Length : {jagged2.Length}, ");

                foreach(char value in array)
                {
                    Console.Write($"{value} ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
