using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
namespace Interface
{
    //Interface 
    //인터페이스를 상속할 수 있는 것은 클래스뿐만 아니라, 구조체, 인터페이스도 상속이 가능하다 
    //기존의 인터페이스에서 새로운 기능을 추가한 인터페이스를 만들고 싶을때면 인터페이스를 상속하는 
    //인터페이스를 만들면 가능하다 
    interface ILogger
    {
        void WriteLog(string p_smessage);
    }
    interface IFormattableLogger : ILogger
    {
        void WriteLog(string p_sFormat, params Object[] args);
    }
    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string p_smessage)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {p_smessage}");
        }
        public void WriteLog(string p_sFormat, params object[] args)
        {
            string sTempMessage = String.Format(p_sFormat, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {sTempMessage}");
        }
    }
}

namespace Practice19_1
{

    class Program
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The World is not Flat");
            logger.WriteLog("{0} + {1}={2}", 1, 1, 2);
        }
    }
}
