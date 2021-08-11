using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice28_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long lSomeValue = 0x123456789ABCDEF0;
            Console.WriteLine($"{"Original Data", -1} : 0x{lSomeValue:X16}");

            Stream outStream = new FileStream("a.dat", FileMode.Create);
            byte[] arrayWritrByte = BitConverter.GetBytes(lSomeValue);

            Console.WriteLine($"{"Byte Array",-13}:");

            foreach (var value in arrayWritrByte)
            {
                Console.WriteLine($"{value:X2}\r\n");
            }
            Console.WriteLine();

            outStream.Write(arrayWritrByte, 0, arrayWritrByte.Length);
            outStream.Close();

            Stream inStream = new FileStream("a.dat", FileMode.Open);
            byte[] arrayReadByte = new byte[8];
            int i = 0;
            while (inStream.Position < inStream.Length)
            {
                arrayReadByte[i++] = (byte)inStream.ReadByte();
            }
            long lReadValue = BitConverter.ToInt64(arrayReadByte, 0);
            Console.WriteLine($"{"Read Data",-13} : 0x{lReadValue:X16}");
            Console.ReadLine();
        }
    }
}
