using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a simple pizza factory");
            
            PizzaStore pizzaStore = new PizzaStore();
            pizzaStore.OrderPizza("Cheese");
            Console.ReadLine();

        }
    }
}
