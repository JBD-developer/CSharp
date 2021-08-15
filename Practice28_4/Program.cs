using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice28_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("a.txt");
           
            sw.WriteLine("sw.Write()"); 
            sw.WriteLine("sw.Write()"); 
            sw.WriteLine("sw.WriteLine()"); 
            sw.WriteLine("sw.WriteLine()"); 
            sw.Close(); 
            StreamReader sr = new StreamReader("a.txt"); 
            
            while (sr.Peek() >= 0) 
            {
                Console.WriteLine(sr.ReadLine()); 
            } 
            sr.Close();

   
            Console.ReadLine();
        }
    }
}
