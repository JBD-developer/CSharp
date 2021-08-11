using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice28_1
{
    class Program
    {
        static void LF_OnWrongPathType(string p_sType)
        {
            Console.WriteLine($"{p_sType} is wrong type");
            return;
        }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine($"Usage : Practice28_1.exe<Path>[Type:File/Directory]");
                return;
            }
            string sPath = args[0];
            string sType = "File";
            if (args.Length > 1)
            {
                sType = args[1];
            }

            if (File.Exists(sPath)||Directory.Exists(sPath))
            {
                if (sType == "File")
                {
                    File.SetLastWriteTime(sPath, DateTime.Now);
                }
                else if(sType == "Directory")
                {
                    Directory.SetLastWriteTime(sPath, DateTime.Now);
                }
                else
                {
                    LF_OnWrongPathType(sPath);
                    return;
                }
                Console.WriteLine($"Updated {sPath} {sType}");
            }
            else
            {
                if (sType == "File")
                {
                    File.Create(sPath).Close();
                }
                else if (sType == "Directory")
                {
                    Directory.CreateDirectory(sPath);
                }
                else
                {
                    LF_OnWrongPathType(sPath);
                    return;
                }
                Console.WriteLine($"Created {sPath}, {sType}");
            }
        }
    }
}
