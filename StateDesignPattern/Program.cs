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

            StartState start = new StartState();
            start.doAction(c);

            Console.WriteLine("Start State");

            EndState end = new EndState();
            end.doAction(c);

            Console.WriteLine("End State");

            Console.ReadLine();
        }
    }

    public interface IState
    {
        void doAction(Context context);
    }

    public class StartState : IState
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in Start State");
            context.SetState(this);
        }
    }

    public class EndState : IState
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in End State");
            context.SetState(this);
        }
    }


    public class Context
    {
        private IState _state;

        public Context()
        {
            _state = null;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetState()
        {
            return _state;
        }
    }
}
