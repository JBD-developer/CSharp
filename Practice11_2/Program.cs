using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_2
{
    // Deep Copy / Shallow Copy
    class MyClass
    {
        public int _iMyField1;
        public int _iMyField2;

        public MyClass DeepCopy()
        {
            MyClass clsNewCopy = new MyClass();
            clsNewCopy._iMyField1 = this._iMyField1;
            clsNewCopy._iMyField2 = this._iMyField2;

            return clsNewCopy;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            {
                MyClass clsSoucre = new MyClass();
                clsSoucre._iMyField1 = 10;
                clsSoucre._iMyField2 = 20;

                MyClass clsTarget = clsSoucre;
                clsTarget._iMyField2 = 30;

                Console.WriteLine($"{clsSoucre._iMyField1} {clsSoucre._iMyField2}");
                Console.WriteLine($"{clsSoucre._iMyField1} {clsTarget._iMyField2}");

            }

            Console.WriteLine("Deep Copy");
            {
                MyClass clsSource = new MyClass();
                clsSource._iMyField1 = 10;
                clsSource._iMyField2 = 20;

                MyClass clsTarget = new MyClass();
                clsTarget._iMyField2 = 30;

                Console.WriteLine($"{clsSource._iMyField1} {clsSource._iMyField2}");
                Console.WriteLine($"{clsSource._iMyField1} {clsTarget._iMyField2}");
            }
        }
    }
}
