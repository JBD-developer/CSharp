using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiInterspaceInheritance;

namespace MultiInterspaceInheritance
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    class FlyingCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly Method()");
        }

        public void Run()
        {
            Console.WriteLine("Run Method()");
        }
    }
}
namespace Practice19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar clsCar = new FlyingCar();
            clsCar.Fly();
            clsCar.Run();

            IRunnable iRunable = clsCar as IRunnable;
            iRunable.Run();

            IFlyable iFlyable = clsCar as IFlyable;
            iFlyable.Fly();
        }
    }
}
