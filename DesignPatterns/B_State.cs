using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class B_State
    {
        public abstract void Handle(StateContext context);
    }
    class ConcreteStateA : B_State
    {
        public override void Handle(StateContext context)
        {
            context.State = new ConcreteStateB();
        }
    }
    class ConcreteStateB : B_State
    {
        public override void Handle(StateContext context)
        {
            context.State = new ConcreteStateA();
        }
    }
    class StateContext
    {
        private B_State _state;
        public StateContext(B_State state)
        {
            this.State = state;
        }
        public B_State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State: " +
                  _state.GetType().Name);
            }
        }
        public void Request()
        {
            _state.Handle(this);
        }
    }
}

