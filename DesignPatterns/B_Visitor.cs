using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class B_Visitor
    {
        public abstract void VisitConcreteElementA(
          ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(
          ConcreteElementB concreteElementB);
    }
    class ConcreteVisitor1 : B_Visitor
    {
        public override void VisitConcreteElementA(
          ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",
              concreteElementA.GetType().Name, this.GetType().Name);
        }
        public override void VisitConcreteElementB(
          ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}",
              concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
    class ConcreteVisitor2 : B_Visitor
    {
        public override void VisitConcreteElementA(
          ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",
              concreteElementA.GetType().Name, this.GetType().Name);
        }
        public override void VisitConcreteElementB(
          ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}",
              concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
    abstract class Element
    {
        public abstract void Accept(B_Visitor visitor);
    }
    class ConcreteElementA : Element
    {
        public override void Accept(B_Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
        public void OperationA()
        {
        }
    }
    class ConcreteElementB : Element
    {
        public override void Accept(B_Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
        public void OperationB()
        {
        }
    }
    class ObjectStructure
    {
        private List<Element> _elements = new List<Element>();
        public void Attach(Element element)
        {
            _elements.Add(element);
        }
        public void Detach(Element element)
        {
            _elements.Remove(element);
        }
        public void Accept(B_Visitor visitor)
        {
            foreach (Element element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
