using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice15
{
    //Partial Class 
    //분할 클래스란 여러번에 나눠서 구현하는 클래스를 의미한다
    //분할 클래스는 그 자체로 특별한 기능을 하는 것은 아니며, 클래스의 구현이 길어질 경우 
    //여러 파일에 나눠서 구현 할 수 있게 함으로써 소스 코드 관리의 편의를 제공하는데 의의가 있다
    
     partial class Myclass
    {
        public void Method1()
        {
            Console.WriteLine("Method1()");
        }
        public void Method2()
        {
            Console.WriteLine("Method2()");
        }
        
    }

    partial class Myclass
    {
        public void Method3()
        {
            Console.WriteLine("Method3()");
        }
        public void Method4()
        {
            Console.WriteLine("Method4()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass clsMyclass = new Myclass();
            clsMyclass.Method1();
            clsMyclass.Method2();
            clsMyclass.Method3();
            clsMyclass.Method4();

        }
    }
}
