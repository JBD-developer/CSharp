using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_5
{
    //Access Modifier 
    //public 클래스의 내/외부 모두 접근 
    //protected 클래스의 외부에서는 접근 불가, 파생 클래스에서는 접근이 가능 
    //private 클래스의 내부에서만 접근 가능,  파생 클래스에서도 접근이 불가 

    //internal 
    //같은 어셈블리에 있는 코드에서만 public으로 접근 가능 다른 어셈블리에 있는 코드에서는 private와 같은 수준의 접근성 

    //protected internal
    //같은 어셈블리에 있는 코드에서만 protected로 접근 가능 다른 어셈블리에 있는 코드에서는 private와 같은 수준의 접근성 

    //private protected 
    //같은 어셈블리에 있는 클래스에서 상속받는 클래스 내부에서만 접근이 가능
    class WaterHeater
    {
        protected int _iTemperature; 
        
        public void SetTemperature(int p_iTemperature)
        {
            if(p_iTemperature <-5 || p_iTemperature > 42)
            {
                throw new Exception("Out of Temperature Range");
            }
            this._iTemperature = p_iTemperature;
        }
        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {_iTemperature}");
        }
    }
    class Program
    {
         
        static void Main(string[] args)
        {
            try
            {
                WaterHeater clsHeater = new WaterHeater();
                clsHeater.SetTemperature(20);
                clsHeater.TurnOnWater();

                clsHeater.SetTemperature(-2);
                clsHeater.TurnOnWater();

                clsHeater.SetTemperature(50);
                clsHeater.TurnOnWater();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
