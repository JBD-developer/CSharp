using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice27_00
{
    class Program
    {
        private delegate int RunCalc(int a, int b);

        private static int LF_Sum(int p_num1, int p_num2)
        {
            return p_num1 + p_num2;
        }

        private static int LF_Mul(int p_num1, int p_num2)
        {
            return p_num1 * p_num2;
        }

        static void Main(string[] args)
        {
            RunCalc run = LF_Sum;
            Console.WriteLine(run(1, 4));
        }
    }
}
