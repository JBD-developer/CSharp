using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace Practice28
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory= string.Empty;
            if (args.Length < 1)
            {
                directory = string.Empty;
            }
            else
            {
                directory = args[0];
                Console.WriteLine($"directory Info : {directory}");
                Console.WriteLine("-Directorys-");

                var directories = (from dir in Directory.GetDirectories(directory)
                                   let info = new DirectoryInfo(dir)
                                   select new
                                   {
                                       Nemae = info.Name,
                                       Attribute = info.Attributes
                                   }).ToList();

                foreach (var item in directories)
                {
                    Console.WriteLine($"{item.Nemae} : {item.Attribute}");
                }
                Console.WriteLine("-Files-");
                var files = (from file in Directory.GetFiles(directory)
                             let info = new FileInfo(file)
                             select new
                             {
                                 Name = info.Name,
                                 FileSize = info.Length,
                                 Attribute = info.Attributes
                             }).ToList();
                foreach (var item in files)
                {
                    Console.WriteLine($"{item.Name} : {item.Attribute}");
                }
            }
                Console.ReadLine();
        }
    }
}
