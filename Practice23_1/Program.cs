using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Practice23_1
{
    //Collection 
    //Queue 
    //Queue는 대기열, 즉 기다리는 줄이라는 의미이다
    //Queue 자료구조는 데이터 작업을 차례대로 입력했다가 입력된 순서대로 하나씩 처리하기 위해서 사용된다 
    //ArrayList , Array가 원하는 위치에서 자유롭게 접근하는 반면에 Queue의 입력은 오직 뒤에서 출력은 오직 앞에서 이루어진다 
    //데이터 입력은 Enqueue() Method
    //데이터 출력은 Dequeue() Method
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
