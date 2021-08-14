using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice28_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = File.Create("a.txt");
            FileInfo fileInfo = new FileInfo("b.txt");
            FileStream fileStream1 = fileInfo.Create();

            fileStream.Close();
            fileStream1.Close();
            File.Copy("a.txt", "c.txt");
            FileInfo fileInfo2 = fileInfo.CopyTo("d.txt");
            
        }
    }
}
