using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice28_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader 

            //string sLine = string.Empty;
            //using(StreamReader reader = new StreamReader(@"E:\workSpace_Etc\data.txt"))
            //{
            //    while ((sLine = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(sLine);
            //    }
            //}
            //using (StreamReader reader = new StreamReader(@"E:\workSpace_Etc\data.txt"))
            //{
            //    int iChar = reader.Read();
            //    Console.WriteLine($"iChar : {iChar.ToString()}");

            //    char[] arrayBuffer = new char[10];

            //    int iReadCount = reader.Read(arrayBuffer, 0, arrayBuffer.Length);
            //    for (int i = 0; i < arrayBuffer.Length; i++)
            //    {
            //        Console.WriteLine($"arrayBuffer{i} = {arrayBuffer[i]}");
            //    }
            //    Console.WriteLine(arrayBuffer);

            //    Console.ReadLine();
            //}

            //FileReader 
            string sData = File.ReadAllText(@"E:\workSpace_Etc\data.txt");
            Console.WriteLine($"sData = {sData}");

            string[] arrLine = File.ReadAllLines(@"E:\workSpace_Etc\data.txt");
            for (int i = 0; i < arrLine.Length; i++)
            {
                Console.WriteLine($"arrLine{i} : {arrLine[i]}");
            }

            IEnumerable<string> lines = File.ReadLines(@"E:\workSpace_Etc\data.txt");
            foreach(string line in lines)
            {
                Console.WriteLine($"{line}");
            }
            Console.ReadLine();
        }
    }
}
