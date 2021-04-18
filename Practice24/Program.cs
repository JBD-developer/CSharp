using System;
using System.Collections;
using Indexer;
using Yield;

namespace Yield
{
    class MyEnumrator
    {
        int[] numbers = { 99, 98, 97, 96, 95 };

        public IEnumerator GetEnumerator()
        {
            
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield return numbers[3];
            yield break;
            yield return numbers[4];



        }
    }
}
namespace Indexer
{
    //Indexer 
    //Indexer는 Index를 이용하여 객체내의 데이터에 접근하게 해주는 Property라고 볼 수 있다
    //객체를 마치 배열처럼 사용할 수 있게 해준다 
    class MyList
    {
        private int[] _iArray;

        public MyList()
        {
            _iArray = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return _iArray[index];
            }

            set
            {
                if(index >= _iArray.Length)
                {
                    Array.Resize<int>(ref _iArray, index + 1);
                    Console.WriteLine($"_iArray.Resized : {_iArray.Length}");
                }
                _iArray[index] = value;
            }
        }
        public int Length
        {
            get { return _iArray.Length; }
        }
    }

}
namespace Practice24
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
            {
                list[i] = i;

            }
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine();

            var obj = new MyEnumrator();
            foreach (int i in obj)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
