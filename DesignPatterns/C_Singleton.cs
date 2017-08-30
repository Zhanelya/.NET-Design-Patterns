using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class C_Singleton
    {
        private static C_Singleton _instance; //has to be static
        private string _name;
        private string _age;
        private C_Singleton(string name,string age) //can be protected or public
        {
            this._name = name;
            this._age = age;
        }
        public static C_Singleton Instance(string name, string age) //has to be static
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new C_Singleton(name, age);
            }
            return _instance;
        }
        public void SayHello()
        {
            Console.WriteLine("Hello, my name is "+ _name + " I'm "+ _age);
        }
    }
}
