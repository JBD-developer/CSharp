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
            string sLine = string.Empty;
            using(StreamReader reader = new StreamReader(@"E:\workSpace_Etc\data.txt"))
            {
                while ((sLine = reader.ReadLine()) != null)
                {
                    Console.WriteLine(sLine);
                }
            }
            using (StreamReader reader = new StreamReader(@"E:\workSpace_Etc\data.txt"))
            {
                int iChar = reader.Read();
                Console.WriteLine($"iChar : {iChar.ToString()}");
                
                char[] arrayBuffer = new char[10];

                int iReadCount = reader.Read(arrayBuffer, 0, arrayBuffer.Length);
                for (int i = 0; i < arrayBuffer.Length; i++)
                {
                    Console.WriteLine($"arrayBuffer{i} = {arrayBuffer[i]}");
                }
                Console.WriteLine(arrayBuffer);

                Console.ReadLine();
            }
        }
    }
}
