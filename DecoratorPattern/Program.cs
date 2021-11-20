using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza cheezeDecorator = new CheeseDecorator(pizza);
            IPizza tomatoDecorator = new TomatoDecorator(cheezeDecorator);
            IPizza onionDecorator = new OnionDecorator(tomatoDecorator);
            Console.WriteLine(onionDecorator.GetPizzaType());
            Console.ReadLine();
        }
    }
}
