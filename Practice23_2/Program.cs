using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practice23_2
{
    //Collection 
    //Stack
    //Stack는 먼저 들어온 데이터가 나중에 나가는 선입후출(First In Last Out)구조인 Queue와는 반대로 
    //나중에 들어온 데이터가 먼저 나가는 후입선출(Last In First Out) 구조의 Collection 이다
    //데이터 입력은 Push() Method
    //데이터 출력은 Pop() Method 
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
                Console.WriteLine($"{stack.Pop()}");
            }
        }
    }
}
