using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12_2
{
    //Overriding Polymorphism

    //객체 지향 프로그래밍에서 Polymorphism은 객체가 여러 형태를 가질 수 있음을 의미한다. 
    //다형성은 원래 하위 형식 다형성(Subtype Polymorphism)의 줄임말이다.
    //자신으로부터 상속을받아 만들어진 파생 클래스를 통해서 다형성을 실현한다는 의미이다.  

    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannos Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create ArmorSuite...");
            ArmorSuite clsArmorSuite = new ArmorSuite();
            clsArmorSuite.Initialize();

            Console.WriteLine("\nCreating IronMan");
            ArmorSuite clsIronMan = new IronMan();
            clsIronMan.Initialize();

            Console.WriteLine("\nCreating WarMachine");
            ArmorSuite clsWarMachine = new WarMachine();
            clsWarMachine.Initialize();
        }
    }
}
