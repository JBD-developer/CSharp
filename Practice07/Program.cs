using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice07
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# NUllable 형식 
            //int 형식의 변수를 선언하면 4Byte 의 메모리가 할당된다. 
            //C# Compiler은 이 메모리 공간에 어떤 값이든 넣도록 강제한다. 
            //하지만 어떤 값도 가지지 않는 변수가 가끔 필요할 경우가 있다. 
            //0이 아닌 비어있는 변수에게 메모리 공간을 비워둘 수 있도록 Nullable 형식을 사용한다. 
            //Nullable 형식을 사용할 수 있느 경우는 값형식에 한정한다. 
            //데이터 형식? 변수이름 

            int? iNumA = null;

            Console.WriteLine(iNumA.HasValue);
            Console.WriteLine(iNumA != null);

            iNumA = 1118;
            Console.WriteLine(iNumA.HasValue);
            Console.WriteLine(iNumA != null);
            Console.WriteLine(iNumA.Value);

            //C# Var 형식 
            //C#은 변수나 상수에 대해 깐깐하게 형식 검사를 하는 강력한 형식의 언어 Strong Typed Language이다. 
            //때문에 의도치 않은 형식의 데이터를 읽거나 할당하는 일을 막아준다.
            //강력한 형식 검사를 하는 언어이지만 var 키워드를 통해 약한 형식 검사를 하는 언어의 편리함도 지원한다. 
            //int, string 같은 명시적 형식 대신에 var 키워드를 이용해 변수를 선언하면 Compiler가 자동으로 해당 변수의
            //형식을 지정해준다. 

            var a = 3; // a는 int 형식 
            var b = "Hello World"; //  b는 string 형식 
            var c = 3.1414213;
            var d = new int[] { 1, 2, 3 };
            //var는 지역변수로만 사용할 수 있다. 
            //class의 field를 선언할 때는 반드시 명시적 형식을 선언해야 한다. 
            //class의 field는 선언과 같이 초기화 하지 않는 경우가 많은데 var 키워드로 선언하면 
            //Compiler가 무슨 형식인지 파악할 수가 없다. 

            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);
            Console.Write("Type : {0}, Value : ", d.GetType());
            foreach (var e in d)
            
                Console.Write("{0} ", e);
            
            Console.WriteLine();
        }
    }
}
