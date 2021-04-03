using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12_3
{
    //Method Hiding
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }
    class Derived : Base
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base clsBase = new Base();
            clsBase.MyMethod();

            Derived clsDerived = new Derived();
            clsDerived.MyMethod();

            Base clsDervied2 = new Derived();
            clsDervied2.MyMethod();
        }
    }
}
