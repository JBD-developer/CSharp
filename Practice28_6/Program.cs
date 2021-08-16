using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice28_6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"E:\workSpace_Etc\data.txt"))
            {
                writer.WriteLine("Line 1");
                writer.WriteLine("Line 1");

                decimal val = 1024.10m;
                writer.WriteLine(val);
                char [] array = new char[5] { 'A', 'B', 'C', 'D', 'E' };
                writer.WriteLine(array);
            }
        }
    }
}
