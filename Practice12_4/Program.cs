using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12_4
{
    //Overriding 봉인 
    //클래스를 상속이 되지 않도록 봉인하는 것처럼 메소드도 오버라이딩 되지 않도록 seal 키워드 사용한다

    class Base
    {
        public virtual void SealMe()
        {
            Console.WriteLine("Base.SealMe()");
        }
    }
    class Derived : Base
    {
        public sealed override void SealMe()
        {
            base.SealMe();
            Console.WriteLine("Derived.SealMe()");
        }
    }
    //class WantToOverride : Derived
    //{
    //    public override void SealMe()
    //    {
    //        Console.WriteLine("WantToOverride.SealMe()");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Base clsBase = new Base();
            clsBase.SealMe();

            Derived clsDerived = new Derived();
            clsDerived.SealMe();
        }
    }
}
