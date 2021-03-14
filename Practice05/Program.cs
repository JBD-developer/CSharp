using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing UnBoxing
            //Value Type : 값을 변수에  넣는 데이터 형식 (stack)
            //Reference Type : 변수에 대한 위치를 담는 데이터 형식 (heap)  
            //object, string 형식은 참조 형식이기 때문에 heap에 데이터를 할당한다. 
            //int, double 형식은 값 형식이기 때문에 stack에 데이터를 할당한다. 
            
            int iNumA = 20;
            object objA = (object)iNumA; //iNumA에 담긴 값을 Boxing 해서 heap에 저장
            int iNumB = (int)objA; //objA에 담긴 값을 UnBoxing 해서 stack에 저장 
            
            Console.WriteLine($"iNumA = {iNumA}");  
            Console.WriteLine($"objA = {objA}"); 
            Console.WriteLine($"iNumB = {iNumB}");

            double dNumA = 3.1414213;
            object objB = (object)dNumA;
            double dNumB = (double)objB;

            Console.WriteLine($"dNumA = {dNumA}");
            Console.WriteLine($"objB = {objB}");
            Console.WriteLine($"dNumB = {dNumB}");

        }
    }
}
