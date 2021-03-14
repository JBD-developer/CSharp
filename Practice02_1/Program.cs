using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //변수는 데이터를 담는 그릇이다. 
            //그릇에 용량 이상의 물을 담으면 넘치는 것처럼, 변수에도 데이터 형식의 크기의 값을 담으면 넘친다 
            //이런 현상을  Overflow 이라고 한다 
            //데이터 형식의 범위를 넘어가는 값일 경우 OverFlow가 발생, 데이터 형식이 가질 수 있는 가장 최저값이 된다 

            uint uNumA = uint.MaxValue;
            Console.WriteLine(uNumA);

            uNumA = uNumA + 1;
            Console.WriteLine(uNumA);
        }
    }
}
