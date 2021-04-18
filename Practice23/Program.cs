using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practice23
{
    //Collection 
    //ArrayList 
    //ArrayList는 가장 배열과 닮은 컬렉션이라고 할 수 있다 
    //요소에 접근할 때는 [] 연산자를 이용, 특정 위치에 있는 요소에 데이터를 임의로 할당할 수도 있다
    //배열과는 달리 컬렉션을 생성할 때 용량을 미리 지정할 필요가 없이 필요에 따라 자동으로 용량이 증가, 감소하느 것이 
    // ArrayList의 가장 큰 장점이다 
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for(int i=0; i<5; i++)
            {
                list.Add(i);
            }
            foreach(object obj in list)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();

            list.RemoveAt(2);

            foreach(object obj in list)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();

            Random random = new Random();
            for(int i=0; i<list.Count; i++)
            {
                list[i] = random.Next(0, 10);
            }

            foreach (object obj in list)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
        }
    }
}
