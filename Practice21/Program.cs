using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property;
namespace Property
{
    //Property 
    class BirtyDayInfo
    {
        private string _sName;
        private DateTime _dBirthDay;
    
        public string Name
        {
            get
            {
                return _sName;
            }
            set
            {
                _sName = value;
            }
        }

        public DateTime BirtyDay
        {
            get
            {
                return _dBirthDay;
            }
            set
            {
                _dBirthDay = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(_dBirthDay).Ticks).Year;
            }
        }
    }
}
namespace Practice21
{
    class Program
    {
        static void Main(string[] args)
        {
            BirtyDayInfo clsBirthDayInfo = new BirtyDayInfo();
            clsBirthDayInfo.Name = "Kim";
            clsBirthDayInfo.BirtyDay = new DateTime(1991, 6, 21);

            Console.WriteLine($"Name : {clsBirthDayInfo.Name}");
            Console.WriteLine($"BirtyDay : {clsBirthDayInfo.BirtyDay} ");
            Console.WriteLine($"Age : {clsBirthDayInfo.Age}");
        }
    }
}
