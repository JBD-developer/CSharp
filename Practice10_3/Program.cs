using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_3
{
    class Program
    {
        private static void LF_Swap(ref int p_iNumA, ref int p_iNumB)
        {
            int iTemp = p_iNumB;
            p_iNumB = p_iNumA;
            p_iNumA = iTemp;
        }
        static void Main(string[] args)
        {
            int iTempX = 3;
            int iTempY = 6;

            Console.WriteLine($"iTempX : {iTempX} iTempY : {iTempY} ");
            LF_Swap(ref iTempX, ref iTempY);

            Console.WriteLine($"iTempX : {iTempX} iTempY : {iTempY} ");

            //참조에 의한 전달(pass by reference)
            //값에 의한 전달이 매개변수가 변수 , 상수로 부터 값을 복사하는 것 과는 달리 
            //참조에 의한 전달은 매개변수가 Method에 넘겨진 원본 변수를 직접 참조한다. 
            //따라서 Method안에서 매개변수를 수정하면 이 매개변수가 참조하고 있는 원본 변수 수정이 이루어 진다. 
        }
    }
}
