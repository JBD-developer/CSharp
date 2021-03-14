using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice06
{
    class Program
    {
        
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK}
        static void Main(string[] args)
        {
            //C# Constants Enumerator 
            //const 자료형 상수명 = 값; 

            const int MAX_INT = int.MaxValue;
            const int MIN_INT = int.MinValue;

            Console.WriteLine($"MAX_INT = {MAX_INT}");
            Console.WriteLine($"MAX_INT = {MIN_INT}");

            //enum 열겨 형식명 : 기반 자료형 {상수1, 상수2, 상수3, ...}
            //enum 기반 자료형은 정수계열만 사용할 수 있으며 생략할 경우 컴파일러가 int를 기반 자료형으로 사용한다. 
            //enum 의 첫버쨰 형식 요소에는 0, 그 다음에는 1, 다음 요소에는 2의 식으로 1씩 증가한 값을 컴파일러가 
            //자동적으로 할당한다. 

            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);
        }
    }
}
