using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_2
{
    class Program
    {
        private static void LF_Swap(int p_iNumA, int p_iNumB)
        {
            int iTemp = p_iNumB;
            p_iNumB = p_iNumA;
            p_iNumA = iTemp; 
        }
        static void Main(string[] args)
        {
            int iTempX = 3;
            int iTempY = 4;

            Console.WriteLine($"iTempX : {iTempX}, iTempY : {iTempY}");

            LF_Swap(iTempX, iTempY);

            Console.WriteLine($"iTempX : {iTempX}, iTempY : {iTempY}");
            //매개변수 
            //Main() Method 안에서 LF_Swap Method에 
            //iTempX는 매개변수 p_iNumA로, iTempY는 매개변수 p_iNum로 넘어 간다
            //인수로 넘어간 iTempX와 iTempY는 실제로 LF_Swap() Method 안으로 들어가는 것이 아니다. 
            //Method 외부로 부터 Method 내부로 데이터를 전달받는 매개체 역할을 할 뿐이다. 
            //한 변수를 또 다른 변수에 할당하면 변수가 담고 있는 데이터만이 복사될 뿐이다. 
            //p_iNumA는 iTempX가 가진 것과 똑같은 데이터를 가지고 있지만, p_iNumA는 iTempX는 완전히 
            //별도의 메모리 공간을 가진다. 이처럼 Method 를 호출할 때 데이터를 복사해서 매개변수를 넘기는 것을 
            //값에 의한 전달(pass by value)라고 한다. 
        }
    }
}
