using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 
namespace Practice23_3
{
    //Collection 
    //Hashtable
    //Hashtable은 키(Key) 값(value) 쌍으로 이루어진 데이터를 다룰 때 사용한다
    //탐색 속도가 빠르고 사용하기도 편하다 
    //Array, ArrayList와 다른 점이라면 데이터를 저장할 요소의 위치로 index를 사용하는 반면에
    //Hashtable은 키 데이터를 그대로 사용한다 
    //탐색속도가 거의 소요되지 않는다 ArrayList에서 원하는데이터를 찾으려면 Collection을 정렬해서 
    //이진탐색, 혹은 순차적으로 탐색해 나가지만, Hashtable은 키를 이용해서 단번에 Collection에 
    //저장된 Collection 내의 주소를 계산해 낸다 
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["One"] = "하나";
            ht["Two"] = "둘";
            ht["Three"] = "셋";
            ht["Four"] = "넷";
            ht["Five"] = "다섯";

            ht.Add("Six", "여섯");
            ht.Add("Seven", "일곱");
            ht.Add("Eight", "여덟");
            
            
            Console.WriteLine($"{ht.Keys}");
            //for(int i=0; i<ht.Count; i++)
            //{
            //    Console.WriteLine(ht.Values);
            //}

            foreach(var value in ht.Keys)
            {
                Console.WriteLine($"{value} : {ht[value]}");
            }

        }
    }
}
