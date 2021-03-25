using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_7
{
    class Program
    {
        // 명명된 인수 (Named Argument) / 선택적 인수 (Optional Argument)
        // Method를 호출할 때 매개변수 목록 중 어느 매개변수에 데이터를 할당한지를 지정하는 것은 
        // "순서"이다 예를 들어 void MyMethod(int a, int b, int c)와 같이 선언된 Method를 
        //MyMethod(1, 2, 3)이라고 호출하면 a = 1, b = 2 , c = 3 이 할당 된다
        //하지만 C#에서는 다른 스타일도 지원한다 그것이 바로 Named Argument이다 
        static void PrintVersion(string p_sName, string p_sVersion)
        {
            Console.WriteLine($"Name : {p_sName} Version : {p_sVersion}");

        }
        static void Main(string[] args)
        {
            PrintVersion(p_sName: ".Net", p_sVersion: "4.6");
            PrintVersion(p_sVersion: "8.0" , p_sName: "Java" );
            PrintFrameWork(p_sName: "Java", p_sFrameWork: "Spring");
            PrintFrameWork(p_sName: "JavaScript");
            PrintFrameWork(p_sFrameWork: "React" , p_sName: "JavaScript");
        }

        //Method의 매개변수는 기본값을 가질 수 있다 
        //기본값을 가진 매개변수는 Method 를 호출할 때 해당 인수를 생략할 수 있으며
        //필요에 따라서는 인수를 입력할 수도 있다 기본 값을 가진 매개변수는 필요에 따라 
        //인수를 할당하거나, 할당하지 않을 수도 있기 때문에 이를 Optional Argument라고 한다 

        static void PrintFrameWork(string p_sName, string p_sFrameWork = "")
        {
            Console.WriteLine($"p_sName : {p_sName} p_sFrameWork : {p_sFrameWork}");
        }
      
    }
}
