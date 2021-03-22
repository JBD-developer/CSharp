using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice08
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# 문자열 다루기 
            string sStr1 = "Good Morning";

            Console.WriteLine(sStr1);
            Console.WriteLine();

            //IndexOf(); 
            //현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 검색
            Console.WriteLine("IndexOf 'Good' : " +sStr1.IndexOf("Good"));
            Console.WriteLine("IndexOf 'o' : " + sStr1.IndexOf("o"));

            //LastIndexOf(); 
            //현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 뒤에서부터 검색 
            Console.WriteLine("LastIndexOf 'Good' : " + sStr1.LastIndexOf("Good"));
            Console.WriteLine("LastIndexOf 'o' : " + sStr1.LastIndexOf("o"));

            //StarstWith() 
            //현재 문자열이 지정된 문자열로 시작하는지를 평가 
            Console.WriteLine("StartsWith 'Good' : " + sStr1.StartsWith("Good"));
            Console.WriteLine("StartsWith 'o' : " + sStr1.StartsWith("o"));

            //EndsWith() 
            //현재 문자열이 지정된 문자열로 끝나는지를 평가 
            Console.WriteLine("EndsWith 'Good' : " + sStr1.EndsWith("Good"));
            Console.WriteLine("EndsWith 'Morning' : " + sStr1.EndsWith("Morning"));

            //Contain
            //현재 문자열이 지정된 문자열을 포함하는지를 평가 
            Console.WriteLine("Contains 'Evening' : " + sStr1.Contains("Evening"));
            Console.WriteLine("Contains 'Morning' : " + sStr1.Contains("Morning"));

            //Replace
            //현재 문자열내에서 지정된 문자열이 다른 문자열로 바뀐 새 문자열을 반환
            Console.WriteLine(sStr1.Replace("Morning", "Evening"));
            Console.WriteLine();

            //C# 문자열 변형하기
            Console.WriteLine("ToLower() " + "ABC".ToLower());
            Console.WriteLine("ToUpper() " + "abc".ToUpper());

            //Insert 
            //현재 문자열의 지정된 위치에 지정된 문자열이 삽입된 새 문자열을 반환
            Console.WriteLine("Insert() " + "Happy Friday!".Insert(5, " Sunny"));

            //Remove 
            //현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자가 삭제된 새 문자열을 반환
            Console.WriteLine("Remove() " + "I Don't Love You!".Remove(2, 6));

            //Trim 
            //현재 문자열의 앞/뒤에 있는 공백을 삭제한 새 문자열을 반환
            Console.WriteLine("Trim() : '{0}'","              NO Space ".Trim());

            //TrimStart()
            //현재 문자열의 앞에 있는 공백을 삭제한 새 문자열을 반환
            Console.WriteLine("TrimStart() : '{0}'" , "    NO Space      ".TrimStart());

            //TrimEnd()
            //현재 문자열의 뒤에 있는 공백을 삭제한 새 문자열을 반환   
            Console.WriteLine("TrimEnd() : '{0}'" , "      NO Space     ".TrimEnd());

        }
    }
}
