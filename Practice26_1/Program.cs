using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice26_1
{
    class Program
    {

        static void DoSomething(int arg)
        {
            if (arg<10)
            {
                Console.WriteLine($"arg : {arg}");
            }
            else
            {
                throw new Exception("arg > 10");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                DoSomething(1);
                DoSomething(3);
                DoSomething(5);
                DoSomething(7);
                DoSomething(9);
                DoSomething(10);
                DoSomething(11);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
