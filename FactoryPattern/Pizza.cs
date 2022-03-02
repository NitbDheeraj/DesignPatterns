using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public string _name;

        public void Prepare()
        {
            Console.WriteLine("Preparing" + _name);
        }
        public void Bake()
        {
            Console.WriteLine("Baking" + _name);
        }
        public void Cut()
        {
            Console.WriteLine("Cutting" + _name);
        }
        public void Box()
        {
            Console.WriteLine("Boxing" + _name);
        }

        public string GetName()
        {
            return _name;
        }
    }

    public class NYStyleCheezePizza: Pizza
    {
        public NYStyleCheezePizza()
        {
            _name = "NY Style Cheese Pizza";
        }
    }

    public class ChicagoStyleCheezePizza : Pizza
    {
        public ChicagoStyleCheezePizza()
        {
            _name = "Chicago Style Cheese Pizza";
        }
    }

}
