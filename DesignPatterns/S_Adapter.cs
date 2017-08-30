using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
    class S_Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();
        public override void Request()
        {
            //do sth
            _adaptee.SpecificRequest();
        }
    }
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
