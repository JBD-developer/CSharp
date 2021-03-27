using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    // Object가ㅣ생성될 때 Constructor이 호출되고 소멸할 때는 Finalizer이 호출된다. 
    // Finalizer을 별도로 구현할 필요가 없다. Garbage Collector가 Object의 소멸을 자동으로 처리한다.
    // 하지만 Garbage Collector가 언제 동작하는지는 예측할 수 없다. 
    class Cat
    {
        public string _sName;
        public string _sColor; 
        
        /// <summary>
        /// Constructor 
        /// </summary>
        public Cat() 
        {
            _sName = "";
            _sColor = "";
        }

        public Cat(string p_sName, string p_sColor)
        {
            _sName = p_sName;
            _sColor = p_sColor;
        }
        public void Meow()
        {
            Console.WriteLine($"{_sName} : Meow~!");
        }
        /// <summary>
        /// Finalizer 
        /// </summary>
        ~Cat()
        {
            Console.WriteLine($"{_sName} : Bye~!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat clsCat1 = new Cat();
            clsCat1._sColor = "White";
            clsCat1._sName = "Kitty";
            clsCat1.Meow();
            Console.WriteLine($"{clsCat1._sName} : {clsCat1._sColor}");
            Cat clsCat2 = new Cat();
            clsCat2._sColor = "Black";
            clsCat2._sName = "Nero";
            clsCat2.Meow();
            Console.WriteLine($"{clsCat2._sName} : {clsCat2._sColor}");
        }
    }
}
