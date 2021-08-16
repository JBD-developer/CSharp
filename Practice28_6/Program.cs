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
            //StreamWriter 
            //using (StreamWriter writer = new StreamWriter(@"E:\workSpace_Etc\data.txt"))
            //{
            //    writer.WriteLine("Line 1");
            //    writer.WriteLine("Line 1");

            //    decimal val = 1024.10m;
            //    writer.WriteLine(val);
            //    char [] array = new char[5] { 'A', 'B', 'C', 'D', 'E' };
            //    writer.WriteLine(array);
            //}

            //FileWriter
            string sData = File.ReadAllText(@"E:\workSpace_Etc\data.txt");
            Console.WriteLine($"sData = {sData}");
            File.WriteAllText("data.out", sData);

            string[] arrWriteLine = { "C#", "is", "more", "than", "Java" };
            File.WriteAllLines("data2.txt", arrWriteLine);
            File.AppendAllText("data2.txt", sData);

            string[] arrReadLine = File.ReadAllLines(@"E:\workSpace_Etc\data.txt");
            for (int i = 0; i < arrReadLine.Length; i++)
            {
                Console.WriteLine($"arrLine{i} : {arrReadLine[i]}");
            }
            File.AppendAllLines("data2.txt", arrReadLine);
            Console.ReadLine();
        }
    }
}
