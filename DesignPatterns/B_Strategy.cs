using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class B_Strategy
    {
        public abstract void AlgorithmInterface();

    }
    class ConcreteStrategyA : B_Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
              "Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
    class ConcreteStrategyB : B_Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
              "Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
    class ConcreteStrategyC : B_Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
              "Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
    class StrategyContext
    {
        private B_Strategy _strategy;
        public StrategyContext(B_Strategy strategy)
        {
            this._strategy = strategy;
        }
        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
