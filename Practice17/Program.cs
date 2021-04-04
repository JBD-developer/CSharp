using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stucture;
using readonlyStructure;
namespace Stucture
{
    //Structure 
    //C#의 복합데이터 형식에는 클래스 이외에도 구조체라는 것이 있다 
    //구조체는 클래스 처럼 필드와 메소드를 가질 수 있는 상당 부분이 비슷하다
    //구조체는 stuct 키워드를 사용해서 선언한다
    //은닉성을 위해서 모든 필드는 반드시  private로 만들어야 하지만
    //문법적으로 구조체가 클래스와 유사하기는 하지만 클래스는 실세계의 객체를 추상화하기 위해서 사용하지만 
    //구조체는 데이터를 담기위한 자료구조로 사용되기 때문에 은닉성을 비롯한 객체지향의 원칙을 구조체에는 
    //강하게 적용하지 않는 편이며 편의를 위하여 public으로 선언해서 사용하는 경우가 많다 
    
    //클래스는 참조형식이고 구조체는 값형식이기 때문에 구조체는 스택에 할당이 되고 인스턴스가 선언된 블록이
    //끝나는 지점의 메모리에서 사라진다 인스턴스의 사용이 끝나면 즉시 메모리에서 제거된다는 점, 가비지 콜렉터를 
    //덜 귀찮게 한다는 점에서 클래스에 비해 성능의 이점을 가진다 

    struct Point3D
    {
        public int _iNumX;
        public int _iNumY;
        public int _iNumZ;

        public Point3D(int p_iX, int p_iY, int p_iZ)
        //구조체는 매개변수가 없는 생성자를 사용할 수는 없다 
        {

            _iNumX = p_iX;
            _iNumY = p_iY;
            _iNumZ = p_iZ;
        }

        public override string ToString()
        {
            return string.Format($"{_iNumX}, {_iNumY} {_iNumZ}");
        }
    }
}

namespace readonlyStructure
{
    //객체는 속성과 기능으로 이루어지는데 다른 말로 속성은 state, 기능은 Behavior이라고 한다
    //객체의 속성으 필드와 프로퍼티를 통해 표현되므로 객체의 상태 또한 필드와 프로퍼티로 표현가능 
    //상태의 변화를 허용하는 객체를 변경가능(Mutable) 객체라고 하며 
    //상태의 변화를 허용하지 않는 객체를 변경불가능 (Immutable) 객체라고 한다 
    //구조체는 모든 필드와 프로퍼티의 값을 수정할 수 없는 변경불가능 구조체로 선언할 수 있다
    //이에 반해 클래스는 변경불가능으로 선언할 수 없다. 
    struct ACSetting
    {
        public readonly double _currentInCelsius;
        public readonly double _target; 

        public ACSetting(double p_dTarget, double p_dCurrentInCelsius)
        {
            this._target = p_dCurrentInCelsius * 1.8 + 32;
            this._currentInCelsius = p_dCurrentInCelsius;
        }
        
        public double GetFaherenheit()
        {
            return _target;
        }

    }
}
namespace Practice17
{

    class Program
    {
        static void Main(string[] args)
        {
            Point3D clsPoint3D1 ;
            //구조체는 new 생성자를 사용하지 않고 선언만으로 인스턴스가 생성된다 
            clsPoint3D1._iNumX = 10;
            clsPoint3D1._iNumY = 20;
            clsPoint3D1._iNumZ = 30;
            Console.WriteLine(clsPoint3D1.ToString());

            Point3D clsPoint3D2 = new Point3D(100, 200, 300);
            //구조체는 생성자를 이용한 인스턴스 생성도 가능하다 
            Console.WriteLine(clsPoint3D2.ToString());

            ACSetting clsACS = new ACSetting(25, 25);
            Console.WriteLine(clsACS.GetFaherenheit());
        }
    }
}
