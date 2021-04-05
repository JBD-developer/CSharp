using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice18
{
    //Tuple 
    //Tuple도 여러 필드를 담을 수 있는 구조체이다 하지만 Tuple는 형식 이름이 존재하지 않기 때문에 
    //응용프로그램 전체에서 사용할 형식을 선언할 때가 아니라 즉석에서 사용할 복합 데이터 형식을 선언할 때 적합하다 
    //Tuple는 구조체 형식이므로 값 형식이다 값형식은 생성된 지역을 벗어나면 stack에서 소멸되기 때문에 프로그램에 
    //장기적인 부담을 주지 않는다는 장점이 있다 

    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (123, 789);
            //명명되지 않은 튜플
            Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");

            var tuple2 = (Name: ".Net Framework", Version: "4.6");
            Console.WriteLine($"{tuple2.Name}, {tuple2.Version}");

            var (name, age) = tuple2;
            //튜플의 분해 
            Console.WriteLine($"{name}, {age}"); 
               
        }
    }
}
