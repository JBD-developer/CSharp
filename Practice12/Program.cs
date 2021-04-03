using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{

    class Base
    {
        protected string _sName;

        public Base(string p_sName)
        {
            this._sName = p_sName;
            Console.WriteLine($"{this._sName}.Base()");
        }
        ~Base()
        {
            Console.WriteLine($"{this._sName}.~Base()");
        }
        public void BaseMethod()
        {
            Console.WriteLine($"{_sName}.BaseMethod()");
        }

    }
    class Derived : Base
    {
        public Derived(string p_sName) : base(p_sName)
        {
            Console.WriteLine($"{this._sName}.Derived");
        }

        ~Derived()
        {
            Console.WriteLine($"{this._sName}.~Derived");
        }
        public void DerivedMethod()
        {
            Console.WriteLine($"{_sName}.DerivedMethod()");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Base clsBase = new Base("clsBase");
            clsBase.BaseMethod();

            Derived clsDerived = new Derived("clsDerived");
            clsDerived.BaseMethod();
            clsDerived.DerivedMethod();
        }
    }
}
