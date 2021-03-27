using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_1
{
    class Global
    {
        public static int _iCount = 0; 
    }

    class ClassA
    {
        public ClassA()
        {
            Global._iCount++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global._iCount++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global._iCount : {Global._iCount}");
            new ClassA();
            new ClassB();
            new ClassA();
            new ClassB();
            Console.WriteLine($"Global._iCount : {Global._iCount}");
        }
    }
}
