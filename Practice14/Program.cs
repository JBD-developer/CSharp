using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice14
{
    //Nested Class 중첩클래스 
    //클래스 안에 선언된 클래스로 자신이 소속된 클래스의 멤버에 자유롭게 접근이 가능하다 
    //중첩 클래스를 쓰는 이유는 다양하지만 기본적으로  클래스 외부에 공개하고 싶지 않은 형식을 만들거나
    //현재 클래스의 일부분처럼  표현할 수 있는 클래스를 만들고자 할 때 사용한다 
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string p_sItem, string p_sValue)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, p_sItem, p_sValue);
        }

        public string GetConfig(string item)
        {
            foreach(ItemValue iv in listConfig)
            {
                if(iv.GetItem() == item)
                {
                    return iv.GetValue();
                }
            }
            return "";
        }
        private class ItemValue
        {
            private string _sItem;
            private string _sValue;

            public void SetValue(Configuration p_objConfig, string p_sItem, string p_sValue)
            {
                this._sItem = p_sItem;
                this._sValue = p_sValue;

                bool found = false; 
                
                //중첩 클래스는 상위의 멤버에 자유롭게 접근이 가능하다. 
                for(int i=0; i< p_objConfig.listConfig.Count; i++)
                {
                    if(p_objConfig.listConfig[i]._sItem == _sItem)
                    {
                        p_objConfig.listConfig[i] = this;
                        found = true;
                        break; 
                    }
                }
                if(found == false)
                {
                    p_objConfig.listConfig.Add(this);
                }
            }

            public string GetItem()
            {
                return _sItem;
            }

            public string GetValue()
            {
                return _sValue;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Configuration clsConfig = new Configuration();
            clsConfig.SetConfig("Version", "V 1.0");
            clsConfig.SetConfig("Size", "655,324KB");

            Console.WriteLine(clsConfig.GetConfig("Version"));
            Console.WriteLine(clsConfig.GetConfig("Size"));

            clsConfig.SetConfig("Version", "V 1.1");
            Console.WriteLine(clsConfig.GetConfig("Version"));

        }
    }
}
