using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    class ConsoleLooger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter _writer;
        
        public FileLogger(string p_spath)
        {
            _writer = File.CreateText(p_spath);
            _writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }

    class ClimateMonitor
    {
        private ILogger _logger;
        public ClimateMonitor(ILogger p_objLogger)
        {
            _logger = p_objLogger;
        }

        public void start()
        {
            while (true)
            {
                Console.WriteLine("온도 입력");
                string sTemptemperature = Console.ReadLine();
                if(sTemptemperature == "")
                {
                    break;
                }
                _logger.WriteLog("현재 온도" + sTemptemperature);
            }
        }
    }
}
namespace Practice19
{
    //interface 
    //인터페이스는 클래스와 비슷해 보이지만 이벤트, 인덱서, 프로퍼티만 가질 수 있다
    //클래스의 경우 접근 제한 한정자를 선언하지 않으면 private 로 선언되지만 
    //인터페이스의 경우 접근 제한 한정자를 사용할 수 없고 모든 것이 public로 선언된다

    //인터페이스를 상속받는 클래스의 인스턴스를 생성하는 것은 가능하다 

    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor clsMonitor = new ClimateMonitor(new FileLogger("MyLog.txt"));

            clsMonitor.start();
        }
    }
}
