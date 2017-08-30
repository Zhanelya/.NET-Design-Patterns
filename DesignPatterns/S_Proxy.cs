using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class ProxySubject
    {
        public abstract void Request();
    }
    class RealSubject : ProxySubject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
    class S_Proxy : ProxySubject
    {
        private RealSubject _realSubject;
        public override void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}
