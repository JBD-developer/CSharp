using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate;
namespace Delegate
    //Delegate
    //Method에 대한 참조 
    //대리자에 메소드의 주소를 할당한 후 대리자를 호출하면 대리자가 이 메소드를 호출해준다 

{
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a , int b)
        {
            return a - b;
        }
    }
}
namespace Practice27
{

    class Program
    {
        static void Main(string[] args)
        {
            Calculator Cal = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Cal.Plus);
            Console.WriteLine(Callback(3, 56));

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));
        }
    }
}
