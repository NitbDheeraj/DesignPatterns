using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Client Code
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();

            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggets operation A.");
            component1.DoA();

            Console.WriteLine("Client triggers operation B.");
            component2.DoB();

            Console.ReadLine();

        }
    }

    // The Mediator interface declares a method used by components to notify the
    // mediator about various events. The Mediator may react to these events and
    // pass the execution to other components.
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }

    // The Base Component provides the basic functionality of storing a
    // mediator's instance inside component objects.
    public class BaseComponent
    {
        protected IMediator _mediator;
        public BaseComponent(IMediator mediator = null) => _mediator = mediator;
        public void SetMediator(IMediator mediator) => _mediator = mediator;
    }

    // Concrete Components implement various functionality. They don't depend on
    // other components. They also don't depend on any concrete mediator
    // classes.
    public class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A");
            _mediator.Notify(this, "A");
        }
    }

    public class Component2 : BaseComponent
    {
        public void DoB()
        {
            Console.WriteLine("Component 2 does B");
            _mediator.Notify(this, "B");
        }

        
    }

    // Concrete Mediators implement cooperative behavior by coordinating several
    // components.
    public class ConcreteMediator : IMediator
    {
        private Component1 _component1;
        private Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            _component1.SetMediator(this);

            _component2 = component2;
            _component2.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers some operation related to A");
                //Can ask any operation from B
            }
            if (ev == "B")
            {
                Console.WriteLine("Mediator reacts on B and triggers some operation related to B");
                //this._component2.DoB();
            }
        }
    }

}
