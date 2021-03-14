using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice03
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# 부동소수점 형식 float, double

            float fNumA = 3.1415_9265_3589_7932_3846f;
            Console.WriteLine(fNumA);

            double dNumA = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(dNumA);

            //부동소수점 형식은 정밀도 면에서 한계를 가지므로 
            //소수데이터를 다룰 때는 염두에 두고 있어야 한다. 
            //float, double 가 있지만 float 보다는 double을 사용하는 것이 좋다.
            //double 형식이 float 형식에 비해 메모리를 두 배로 사용하지만 그만큼 float 형식에 비해 데이터 손실이 적다. 
            //double 형식을 사용했는데도 데이터 손실이 우려 된다면 decimal 형식을 사용하면 된다. 
            //회계 프로그램, 계산기를 프로그래밍 한다면 decimal 형식이 적합하다. 
            float fNumB = 3.1415_9265_3589_7932_3846_2643_3832_79f;
            double dNumB = 3.1415_9265_3589_7932_3846_2643_3832_79;
            decimal dcNumA = 3.1415_9265_3589_7932_3846_2643_3832_79m;

            Console.WriteLine(fNumB);
            Console.WriteLine(dNumB);
            Console.WriteLine(dcNumA);

        }
    }
}
