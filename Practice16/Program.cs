using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtension;


    //Extension Method
    //확장 메소드는 기존 클래스의 기능을 확장하는 기법 
    //기반 클래스를 물려받아 파생 클래스를 만든 뒤 여기에 필드나 메소드를 추가하는 상속과는 다르다 
    //확장 메소드를 선언하는 방법은  static 한정자로 수식해야 한다
    //첫번째 매개변수는 반드시 this 키워드와 함께 확장하고자 하는 클래스의 인스턴스여야 한다.
 namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int p_iMyint)
        {
            return p_iMyint * p_iMyint;
        }

        public static int Power(this int p_iMyint, int p_iExponent)
        {
            int iTempResult = p_iMyint;
            for(int i=1; i < p_iExponent; i++)
            {
                iTempResult = iTempResult * p_iMyint;
            }
            return iTempResult;
        }
    }
}
namespace Practice16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");


        }
    }
}
