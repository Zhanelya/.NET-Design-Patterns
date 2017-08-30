using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class DecoratorComponent
    {
        public abstract void Operation();
    }
    class ConcreteComponent : DecoratorComponent
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
    abstract class S_Decorator : DecoratorComponent
    {
        protected DecoratorComponent component;
        public void SetComponent(DecoratorComponent component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                Console.WriteLine("Call component operation");
                component.Operation();
            }
        }
    }
    class ConcreteDecoratorA : S_Decorator
    {
        public ConcreteDecoratorA(DecoratorComponent component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            Console.WriteLine("Entering ConcreteDecoratorA.Operation()");
            base.Operation();
            Console.WriteLine("Exiting ConcreteDecoratorA.Operation()");
        }
    }
    class ConcreteDecoratorB : S_Decorator
    {
        public ConcreteDecoratorB(DecoratorComponent component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            Console.WriteLine("Entering ConcreteDecoratorB.Operation()");
            base.Operation();
            AddedBehavior();  
            Console.WriteLine("Exiting ConcreteDecoratorB.Operation()");
        }
        void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorB.AddedBehavior()");
        }
    }
}
