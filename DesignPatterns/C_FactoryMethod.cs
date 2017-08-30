using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class C_FactoryMethod
    {
    }
    abstract class FactoryProduct
    {
    }
    class ConcreteProductA : FactoryProduct
    {
    }
    class ConcreteProductB : FactoryProduct
    {
    }
    abstract class Creator
    {
        public abstract FactoryProduct FactoryMethod();
    }
    class ConcreteCreatorA : Creator
    {
        public override FactoryProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
    class ConcreteCreatorB : Creator
    {
        public override FactoryProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
