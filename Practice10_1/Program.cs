using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_1
{
    class Program
    {
        private static int LF_Fibonacci(int p_iNum)
        {
            if(p_iNum < 2)
            {
                return p_iNum;
            }
            else
            {
                return LF_Fibonacci(p_iNum - 1) + LF_Fibonacci(p_iNum - 2);

            }
        }
        private static void LF_ProfilePrint(string p_sName)
        {
            if(p_sName == "")
            {
                return;
            }
            Console.WriteLine($"{p_sName}");
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력해주세요");
            LF_ProfilePrint(Console.ReadLine());
            Console.WriteLine("숫자를 입력해주세요");
            int iTempNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"InputNumber:{iTempNum} Fibonacci Number:{LF_Fibonacci(iTempNum)}");
        }
    }
}
