using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Practice29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11001");
            int iValue = Convert.ToInt32("11001", 2);
            string sHex = Convert_Int_To_HexString1(iValue);
            int iValue2 = Convert_String_To_Int(sHex);
            string sHex2 = Convert_Int_To_HexString2(iValue);
            string sBinary = Convert_Int_To_BinaryString(iValue);
            byte bByte = Convert_HexString_To_Byte(sHex2);
            Console.WriteLine($"sHex = {sHex}");
            Console.WriteLine($"sHex2 = {sHex2}");
            Console.WriteLine($"sBianry = {sBinary}");
            Console.WriteLine($"bByte = {bByte}");
            Console.ReadLine();
        }

        /// <summary>
        /// Convert decimal to hexadecimal string
        /// </summary>
        /// <param name="p_iValue"></param>
        /// <returns></returns>
        static string Convert_Int_To_HexString1(int p_iValue)
        {
            return p_iValue.ToString("X4");
        }

        /// <summary>
        /// Convert decimal to hexadecimal string 
        /// </summary>
        /// <param name="p_iValue"></param>
        /// <returns></returns>
        static string Convert_Int_To_HexString2(int p_iValue)
        {
            return Convert.ToString(p_iValue, 16);
        }

        /// <summary>
        /// Convert hexadecimal string to decimal 
        /// </summary>
        /// <param name="p_sValue"></param>
        /// <returns></returns>
        static int Convert_String_To_Int(string p_sValue)
        {
            return Convert.ToInt32(p_sValue, 16);
        }

        /// <summary>
        /// Convert decimal to binary string 
        /// </summary>
        /// <param name="p_iValue"></param>
        /// <returns></returns>
        static string Convert_Int_To_BinaryString(int p_iValue)
        {
            return Convert.ToString(p_iValue, 2);
        }

        /// <summary>
        /// Convert hexastring to byte
        /// </summary>
        /// <param name="p_sValue"></param>
        /// <returns></returns>
        static byte Convert_HexString_To_Byte(string p_sValue)
        {
            return Convert.ToByte(p_sValue, 16);
        }

    }
}
