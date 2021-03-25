using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_6
{
    class Program
    {
        //Method Overloading 
        
        static int Plus(int p_iNumA, int p_iNumB)
        {
            Console.WriteLine("Calling int Plus (int, int)...");
            return p_iNumA + p_iNumB;
        }
        static int Plus(int p_iNumA, int p_iNumB, int p_iNumC)
        {
            Console.WriteLine("Calling int Plus (int, int, int)...");
            return p_iNumA + p_iNumB;
        }
        static double Plus(double p_dNumA, double p_dNumB)
        {
            Console.WriteLine("Calling int Plus (double,  double)...");
            return p_dNumA + p_dNumB;
        }
        static double Plus(int p_iNumA, double p_dNumB)
        {
            Console.WriteLine("Calling int Plus (int, double)...");
            return p_iNumA + p_dNumB;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(20, 4.5));

            int iTempSum = Sum(1, 2, 3, 4, 10, 11);
            Console.WriteLine($"iTempSum : {iTempSum}");
        }

        static int Sum(params int[] args)
        {
            Console.WriteLine("Summing...");

            int iTempSum = 0;
            for(int i=0; i<args.Length; i++)
            {
                if(i > 0)
                {
                    Console.Write(",");
                }
                Console.Write(args[i]);
                iTempSum += args[i];
            }
            Console.WriteLine();

            return iTempSum;
        }
        //인수가 다른 다는 이유만으로 똑같은 Method 를 여러개로 Overloading 하고 싶은 
        //경우가 있다. 이런 경우를 위해서 C#은 "가변 개수의 인수"라는 기능을 제공한다. 
        //가변 개수의 인수란, 그 개수가 유연하게 변할 수 있는 인수를 의미한다.
        //가변개수의 인수는 params 키워드와 배열을 이용해서 선언한다. 

    }
}
