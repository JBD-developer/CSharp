using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClass;
//abstract class 
//추상클래스는 구현을 가질 수 있지만 인스턴스를 가질 수는 없다 
//추상클래스 역시 접근 한정자를 명시하지 않으면 모든 메소드가 private로 선언된다 
//추상클래스는 abstract method를 가질 수 있다 
namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PulbicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractBaseA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractBaseA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
}
namespace Practice20
{

    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractBaseA();
            obj.PulbicMethodA();
        }
    }
}
