using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Practice23_4
{
    //Collection 
    //Initialize
    //Stack, Queue, ArrayList은 배열의 도움을 받아서 간단하게 초기화가 가능하다 
    //Collection의 생성자를 호출할 때 배열 객체를 매개변수로 넘기면 Collection 객체는 해당 배열을 바탕으로 내부 데이터를 채운다 
    //Stack, Queue는 Collection 초기자를 이용할 수 없다 
    //Hashtable 초기화의 경우에는 Dictionary Initializer을 이용한다 
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 123, 456, 789 };

            ArrayList list = new ArrayList(array);
            foreach(object item in list)
            {
                Console.WriteLine($"List : {item} ");
            }
            Console.WriteLine();

            Stack stack = new Stack(array);
            foreach(object item in stack)
            {
                Console.WriteLine($"Stack : {item}");
            }
            Console.WriteLine();

            ArrayList list2 = new ArrayList() { 100, 101, 102 };

            foreach (object item in list2)
            {
                Console.WriteLine($"List2 : {item} ");
            }
            Console.WriteLine();

            Hashtable ht = new Hashtable() { ["하나"] = 1, ["둘"] = 2, ["셋"] = 3 };

            foreach(var value in ht.Keys)
            {
                Console.WriteLine($"{value}, {ht[value]}");
            }


        }
    }
}
