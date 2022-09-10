using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{

    // The state pattern is a behavioral software design pattern that allows an object
    // to alter its behavior when its internal state changes.
    class Program
    {
        static void Main(string[] args)
        {

            Context c = new Context();

            State1 start = new State1();
            start.ChangeBehavior(c);

            Console.WriteLine("Start State");

            State2 end = new State2();
            end.ChangeBehavior(c);

            Console.WriteLine("End State");

            Console.ReadLine();
        }
    }

    public interface IState
    {
        void ChangeBehavior(Context context);
    }

    public class State1 : IState
    {
        public void ChangeBehavior(Context context)
        {
            Console.WriteLine("State 1");
            context.SetState(this);
        }
    }

    public class State2 : IState
    {
        public void ChangeBehavior(Context context)
        {
            Console.WriteLine("State 2");
            context.SetState(this);
        }
    }


    public class Context
    {
        private IState _state;

        public Context() => _state = null;

        public void SetState(IState state) => _state = state;

        public IState GetState() => _state;
    }
}
