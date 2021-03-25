using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_5
{
    class Program
    {
        //출력 전용 매개변수 out
        
        static void Divide(int p_iNumA, int p_iNumB, out int p_iNumQuotient, out int p_iNumRemainder)
        {
            p_iNumQuotient = p_iNumA / p_iNumB;
            p_iNumRemainder = p_iNumA % p_iNumB;
        }
        static void Main(string[] args)
        {
            int iTempNumA = 30;
            int iTempNumB = 3;

            Divide(iTempNumA, iTempNumB, out int iTempQuotient, out int iTempRemainder);

            Console.WriteLine($" iTempA:{iTempNumA}\n iTempB:{iTempNumB}\n iTempA/iTempB:{iTempQuotient} \n iTempA%iTempB:{iTempRemainder}");
        }
    }
}
