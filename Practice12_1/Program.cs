using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12_1
{
    //기반 클래스와 파생클래스 형식 변환 is as 
    // is 연산자 
    // 객체가 해당 형식에 해당하는지 검사하여 bool 값으로 반환한다 

    //as 연산자 
    //형식 변환 연산자와 같은 역할을 하지만 형식 변환 연산자가 변환에 실패하는 경우 예외를 던지지만 
    //as 연산자는 객체 참조를 null로 만든다

    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse Method()");
        }
    }
    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark Method()");
        }
    }
    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow Method()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal clsMammal = new Dog();
            Dog clsDog;

            if(clsMammal is Dog)
            {
                clsDog = (Dog)clsMammal;
                clsDog.Bark();
            }

            Mammal clsMammal2 = new Cat();
            Cat clsCat = clsMammal2 as Cat;
            
            if(clsCat != null)
            {
                 clsCat.Meow();
            }

            Cat clsCat2 = clsMammal as Cat;
            
            if(clsCat2 != null)
            {
                clsCat2.Meow();
            }
            else
            {
                Console.WriteLine("clsCat2 is Not a Cat");
            }
            
             
        }

    }
}
