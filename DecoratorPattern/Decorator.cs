using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{

    // Base Interface
    public interface IPizza
    {
        string GetPizzaType();
    }

    // Concrete Implementation
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is normal Pizza";
        }
    }
    // Base Decorator
    public class PizzaDecorator : IPizza
    {
        private IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }

    // Concrete Decorators
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string typ = base.GetPizzaType();
            typ += "\r\n with extra cheese!";
            return typ;
        }
    }

    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string typ = base.GetPizzaType();
            typ += "\r\n with extra tomatoes!";
            return typ;
        }

    }

    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string typ = base.GetPizzaType();
            typ += "\r\n with extra onions!!";
            return typ;
        }

    }


}
