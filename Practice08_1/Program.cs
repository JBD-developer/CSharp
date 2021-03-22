using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practice08_1
{
    class Program
    {
        //C# 문자열 분할하기
        static void Main(string[] args)
        {
            string sStr1 = "Hello World C#";
            WriteLine(sStr1.Substring(0, 5));
            WriteLine(sStr1.Substring(6));
            WriteLine();

            string[] arr = sStr1.Split(new String[] {" "}, StringSplitOptions.None);
            WriteLine("Word Count : " + arr.Length);

            foreach(string element in arr)
            {
                WriteLine(element);
            }

        }
    }
}
