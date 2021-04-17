using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice22_1
{
    class Program
    {
        //Array
        //배열을 초기화 하는 방법 세가지 
        string[] _sArray = new string[3] { "C#", ".Net", "4.6" };
        char[] _cArray = new char[] { 'A', 'B', 'C' };
        int[] _iArray = { 12, 13, 14 };

        //System.Array 
        static void Main(string[] args)
        {
            int[] _iArray = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine($"Type Of Array : {_iArray.GetType()}");
            Console.WriteLine($"Base Type of Array : {_iArray.GetType().BaseType}");
        }
    }
}
