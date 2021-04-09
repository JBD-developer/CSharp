using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructorWithProperty;

namespace ConstructorWithProperty
{
    //Property를 이용한 생성자 
    class BirtyDayInfo
    {
        public string Name
        {
            get;
            set;
        }
        public DateTime BirtyDay
        {
            get;
            set;
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(BirtyDay).Ticks).Year;
            }
        }

    }
}
namespace Practice21_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BirtyDayInfo birth = new BirtyDayInfo()
            {
                Name = "Park", 
                BirtyDay = new DateTime(1991, 12, 17)
            };

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"BirtyDay : {birth.BirtyDay}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
