using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice22_2
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        private static void Print(int value)
        {
            Console.WriteLine($"value = {value}");
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 90, 60, 50, 24 };
            
            foreach(int scoreValue in scores)
            {
                Console.WriteLine($"{scoreValue}");
            }
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Number of Dimensions : {scores.Rank}");

            Console.WriteLine($"Binary Search : 80 is at {Array.BinarySearch<int>(scores, 80)}");
            
            Console.WriteLine($"Binary Search : 90 is at {Array.BinarySearch<int>(scores, 90)}");

            Console.WriteLine($"Everyone Passed ? : {Array.TrueForAll<int>(scores, CheckPassed)}");

            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            scores[index] = 61;
            Console.WriteLine($"Everyone Passed ? : {Array.TrueForAll<int>(scores, CheckPassed)}");

            Console.WriteLine($"Old Length Of scores : {scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New Length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            int[] slieced = new int[3];
            Array.Copy(scores, 0, slieced, 0, 3);
            Array.ForEach<int>(slieced, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}
