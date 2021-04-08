using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoImplementedProperty;

namespace AutoImplementedProperty
{
    class BirthDayInfo
    {
        public string Name { get; set; } = "UnKnown";
        public DateTime BirthDay { get; set; } = new DateTime(1, 1, 1);

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(BirthDay).Ticks).Year;
            }
        }
    }
}
namespace Practice21_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthDayInfo clsBirthDayInfo = new BirthDayInfo();
            Console.WriteLine($"Name : {clsBirthDayInfo.Name}");
            Console.WriteLine($"BirthDay : {clsBirthDayInfo.BirthDay}");
            Console.WriteLine($"Age:{clsBirthDayInfo.Age}");

            clsBirthDayInfo.Name = "JEONG";
            clsBirthDayInfo.BirthDay = new DateTime(1987, 11, 28);

            Console.WriteLine($"Name : {clsBirthDayInfo.Name}");
            Console.WriteLine($"BirthDay : {clsBirthDayInfo.BirthDay.ToShortDateString()}");
            
        }
    }
}
