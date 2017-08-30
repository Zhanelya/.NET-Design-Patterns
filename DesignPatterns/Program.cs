using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //B_ChainOfResponsibility cor = new B_ChainOfResponsibility();
            //cor.BChainOfResponsibility();

            //B_Command cmd = new B_Command();
            //cmd.BCommand();

            //B_Interpreter interpreter = new B_Interpreter();
            //interpreter.BInterpreter();

            //B_Iterator iter = new B_Iterator();
            //iter.BIterator();

            //B_Mediator mediator = new B_Mediator();
            //mediator.BMediator();

            //B_Memento memento = new B_Memento();
            //memento.BMemento();

            //B_Observer observer = new B_Observer();
            //observer.BObserver(); 

            //StateContext c = new StateContext(new ConcreteStateA());
            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();

            //StrategyContext context;
            //context = new StrategyContext(new ConcreteStrategyA());
            //context.ContextInterface();
            //context = new StrategyContext(new ConcreteStrategyB());
            //context.ContextInterface();
            //context = new StrategyContext(new ConcreteStrategyC());
            //context.ContextInterface();

            //B_Template template = new B_Template();
            //template.BTemplate();

            //ObjectStructure o = new ObjectStructure();
            //o.Attach(new ConcreteElementA());
            //o.Attach(new ConcreteElementB());
            //ConcreteVisitor1 v1 = new ConcreteVisitor1();
            //ConcreteVisitor2 v2 = new ConcreteVisitor2();
            //o.Accept(v1);
            //o.Accept(v2);

            //Target target = new S_Adapter();
            //target.Request();

            //S_Bridge bridge = new S_Bridge();
            //bridge.SBridge();

            //S_Composite root = new S_Composite("root");
            //root.Add(new Leaf("Leaf A"));
            //root.Add(new Leaf("Leaf B"));
            //S_Composite comp = new S_Composite("Composite X");
            //comp.Add(new Leaf("Leaf XA"));
            //comp.Add(new Leaf("Leaf XB"));
            //root.Add(comp);
            //root.Add(new Leaf("Leaf C"));
            //Leaf leaf = new Leaf("Leaf D");
            //root.Add(leaf);
            //root.Remove(leaf);
            //root.Display(1);

            //ConcreteComponent c = new ConcreteComponent();
            //ConcreteDecoratorA d1 = new ConcreteDecoratorA(c);
            //ConcreteDecoratorB d2 = new ConcreteDecoratorB(d1);
            //d2.Operation();

            //S_Facade facade = new S_Facade();
            //facade.MethodA();
            //facade.MethodB();

            //int extrinsicstate = 22;
            //FlyweightFactory factory = new FlyweightFactory();
            //S_Flyweight fx = factory.GetFlyweight("X");
            //fx.Operation(--extrinsicstate);
            //S_Flyweight fy = factory.GetFlyweight("Y");
            //fy.Operation(--extrinsicstate);
            //S_Flyweight fz = factory.GetFlyweight("Z");
            //fz.Operation(--extrinsicstate);
            //UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            //fu.Operation(--extrinsicstate);

            //S_Proxy proxy = new S_Proxy();
            //proxy.Request();

            //C_AbstractFactory factory1 = new ConcreteFactory1();
            //Client client1 = new Client(factory1);
            //client1.Run();
            //C_AbstractFactory factory2 = new ConcreteFactory2();
            //Client client2 = new Client(factory2);
            //client2.Run();

            //Director director = new Director();
            //C_Builder b1 = new ConcreteBuilder1();
            //C_Builder b2 = new ConcreteBuilder2();
            //director.Construct(b1);
            //Product p1 = b1.GetResult();
            //p1.Show();
            //director.Construct(b2);
            //Product p2 = b2.GetResult();
            //p2.Show();

            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();
            foreach (Creator creator in creators)
            {
                FactoryProduct product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }
            Console.ReadKey();

            //ConcretePrototype1 p1 = new ConcretePrototype1("I");
            //ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            //Console.WriteLine("p1 "+p1.Name + p1.Age);
            //ConcretePrototype2 p2 = new ConcretePrototype2("II");
            //ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            //Console.WriteLine("Cloned: {0}", c2.Id);

            //C_Singleton s1 = C_Singleton.Instance("Jane", "21");
            //s1.SayHello();
            //C_Singleton s2 = C_Singleton.Instance("Harry", "55"); // params will be ignored, and existing Jane-21 singleton will be returned
            //s1.SayHello();
            //s2.SayHello();
            //// Test for same instance
            //if (s1 == s2)
            //{
            //    Console.WriteLine("Objects are the same instance");
            //}
        }
    }
}
