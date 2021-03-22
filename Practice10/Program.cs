using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    class Program
    {
        private static int LF_Add(int p_iNum1, int p_iNum2)
        {
            return p_iNum1 + p_iNum2;

        }
        private static int LF_Sub(int p_iNum1, int p_iNum2)
        {
            return p_iNum1 - p_iNum2;

        }
        private static int LF_Mul(int p_iNum1, int p_iNum2)
        {
            return p_iNum1 * p_iNum2;

        }
        private static double LF_Div(double p_iNum1, double p_iNum2)
        {
            return p_iNum1 / p_iNum2;

        }
        static void Main(string[] args)
        {
            int iTempAddResult = LF_Add(300, 2);
            int iTempSubResult = LF_Sub(200, 12);
            int iTempMulResult = LF_Mul(400, 40);
            double iTempDivResult = LF_Div(4123, 130);

            Console.WriteLine($"iTempAddResult = {iTempAddResult}");
            Console.WriteLine($"iTempSubResult = {iTempSubResult}");
            Console.WriteLine($"iTempMulResult = {iTempMulResult}");
            Console.WriteLine($"iTempDivResult = {iTempDivResult}");

        }
    }
}
