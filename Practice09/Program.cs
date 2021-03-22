using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Console;
namespace Practice09
{
    //C# DateTime
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 03, 22, 13, 14, 00);
            //12시간 형식 2021-03-22 오후 13:14:00(월)
            Console.WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss(ddd)}", dt);

            //24시간 형식 2021-03-22 오후 23:14:00(월)
            Console.WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss(dddd)}", dt);
            Console.WriteLine();

            //CultureInfo class 
            CultureInfo cultureInfoKor = new CultureInfo("ko-KR");
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", cultureInfoKor));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", cultureInfoKor));
            WriteLine(dt.ToString(cultureInfoKor));
            Console.WriteLine();

            CultureInfo cultureInfoEng = new CultureInfo("en-US");
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", cultureInfoEng));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", cultureInfoEng));
            WriteLine(dt.ToString(cultureInfoEng));

        }
    }
}
