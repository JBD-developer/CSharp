using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Git Test");
            Console.WriteLine("Commit Test");

            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Practice01");
                return;
            }
            WriteLine("Hello , {0}", args[0]);
        }
    }
}
