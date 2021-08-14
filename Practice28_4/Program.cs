using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice28_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("a.txt");
            sw.Write(Console.ReadLine());
            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key != ConsoleKey.Escape)
            {
                sw.WriteLine(Console.ReadLine());
            }
            sw.Close();

            StreamReader sr = new StreamReader("a.txt");
            while (sr.Peek()>0)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            Console.ReadLine();
        }
    }
}
