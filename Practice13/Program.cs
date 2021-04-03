using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13
{
    //readonly 읽기 전용 필드  
    //컴파일러는 상수에 지정된 값을 실행파일 안에 기록해둔다. 
    //다시말해 상수는 프로그램이 실행되기 전부터 이미 정해져 있다. 
    //프로그램 실행중에는 절 대로 그 값을 바꿀 수 없다 
    //readonly  상수는  상수와 변수 그 중간 어딘가에 있다? 
    class Configuration
    {
        private readonly int _iMin;
        private readonly int _iMax; 

        public Configuration(int p_iNum1, int p_iNum2)
        {
            _iMin = p_iNum1;
            _iMax = p_iNum2; 
        }

        public void ChangeMax(int p_iNewMax)
        {
            //_iMax = p_iNewMax;
            //생성자가 아닌 다른 곳에서 값을 수정할 경우에는 컴파일 에러가 발생한다. 
        }

        public void PrintConfiguration()
        {
            Console.WriteLine($"_iMin : {_iMin} _iMax : {_iMax}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Configuration clsConfiguration = new Configuration(100, 10);
            clsConfiguration.PrintConfiguration();
        }
    }
}
