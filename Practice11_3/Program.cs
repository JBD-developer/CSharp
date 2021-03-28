using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_3
{
    class ProgrammingLanguage
    {

    
        private string _sName;
        private string _sVersion;

        public void SetName(string p_sName)
        {
            this._sName = p_sName;
        }
        public string GetName()
        {
            return  this._sName;
        }
        public void SetVersion(string p_sVersion)
        {
            this._sVersion = p_sVersion;
        }
        public string GetVersion()
        {
            return this._sVersion;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProgrammingLanguage clsLanguage1 = new ProgrammingLanguage();
            clsLanguage1.SetName("CShape");
            clsLanguage1.SetVersion("6.9");
            Console.WriteLine($"Name: {clsLanguage1.GetName()} , Version : {clsLanguage1.GetVersion()}");

            ProgrammingLanguage clsLanguage2 = new ProgrammingLanguage();
            clsLanguage2.SetName("Java");
            clsLanguage2.SetVersion("8.0");
            Console.WriteLine($"Name: {clsLanguage2.GetName()} , Version : {clsLanguage2.GetVersion()}");
        }
    }
}
