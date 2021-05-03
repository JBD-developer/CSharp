using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstraintOnTypeParameters; 

namespace ConstraintOnTypeParameters
{
    class StructArray<T> where T :struct
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }
    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }

        public  void CopyArray<T>(T[] Score) where T : U
        {
            Score.CopyTo(Array, 0);
        }
    }
}
namespace Practice25_2
{
    class Program
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 1;
            a.Array[1] = 3;
            a.Array[2] = 4;
            for(int i=0; i<a.Array.Length; i++)
            {
                Console.WriteLine(a.Array[i]);
            }

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[0].Array[0] = 1;
            b.Array[0].Array[1] = 1;
            b.Array[0].Array[2] = 1;
            b.Array[0].Array[3] = 1;
            b.Array[0].Array[4] = 1;

            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(105);
            for (int i = 0; i < b.Array.Length; i++)
            {
                Console.WriteLine(b.Array[0].Array[i]);
            }

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);

        }
    }
}
