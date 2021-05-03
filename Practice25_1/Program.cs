                   using System;
using GenericTest;

namespace GenericTest
{
    class MyList<T>
    {
        private T[] _tArray; 

        public MyList()
        {
            _tArray = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return _tArray[index];
            }
            set
            {
                if(index >= _tArray.Length)
                {
                    Array.Resize<T>(ref _tArray, index + 1);
                    Console.WriteLine($"_tArray Resized : {_tArray.Length}");
                }
                _tArray[index] = value;
            }
        }
        public int Length
        {
            get
            {
                return _tArray.Length;
            }
        }
    }
}
namespace Practice25_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";


            for (int i = 0; i < str_list.Length; i++)
            {
                Console.WriteLine($"str_list[{i}] : {str_list[i]}");
            }

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 1;
            int_list[1] = 2;
            int_list[2] = 3;
            int_list[3] = 4;

            for (int i = 0; i < int_list.Length; i++)
            {
                Console.WriteLine($"int_list[{i}]: {int_list[i]}");
            }
        }
    }
}
