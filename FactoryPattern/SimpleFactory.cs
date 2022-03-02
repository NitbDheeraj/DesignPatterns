using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    //Simple Factory is not a design pattern, its a programming Idiom

    public abstract class SimplePizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare");
        }
        public void Bake()
        {
            Console.WriteLine("Bake");
        }
        public void Cut()
        {
            Console.WriteLine("Cut");
        }
        public void Box()
        {
            Console.WriteLine("Box");
        }
    }

    public class CheesePizza: SimplePizza
    {

    }

    public class PeproniPizza : SimplePizza
    {

    }

    public class VeggiePizza : SimplePizza
    {

    }
    public class SimplePizzaFactory
    {
        public static SimplePizza CreatePizza(string pizzaType)
        {
            if (pizzaType == "Cheese")
                return new CheesePizza();
            if (pizzaType == "Peproni")
                return new PeproniPizza();
            if (pizzaType == "Veg")
                return new VeggiePizza();

            return null;
        }
    }

    public class PizzaStore
    {
        SimplePizza _pizza;

        public SimplePizza OrderPizza(string type)
        {
            Console.WriteLine("Preparing Pizza of type " + type);
            _pizza = SimplePizzaFactory.CreatePizza(type);

            _pizza.Prepare();
            _pizza.Bake();
            _pizza.Cut();
            _pizza.Box();

            return _pizza;
        }
    }
}
