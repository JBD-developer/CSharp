using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_4
{
    class MyClass
    {
    private int _iNumA, _iNumB, _iNumC;
        public MyClass()
        {
            this._iNumA = 1111;
            Console.WriteLine("MyClass()");
        }
        public MyClass(int p_iNumB) : this()
        {
            this._iNumB = p_iNumB;
            Console.WriteLine($"MyClass{p_iNumB}");
        }
        public MyClass(int p_iNumB, int p_iNumC):this(p_iNumB)
        {
            this._iNumC = p_iNumC;
            Console.WriteLine($"MyClass{p_iNumB}, {p_iNumC}");
        }
        public void PrintField()
        {
            Console.WriteLine($"_iNumA:{_iNumA}, _iNumB:{_iNumB}, _iNumC:{_iNumC}");
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            MyClass clsA = new MyClass();
            clsA.PrintField();
            Console.WriteLine();

            MyClass clsB = new MyClass(2222);
            clsB.PrintField();
            Console.WriteLine();

            MyClass clsC = new MyClass(3333);
            clsC.PrintField();
            Console.WriteLine();

        }
    }
}
