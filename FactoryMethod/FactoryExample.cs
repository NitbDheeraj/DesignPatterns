using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //The Factory Method design pattern defines an interface for creating an object,
    //but let subclasses decide which class to instantiate.
    //This pattern lets a class defer instantiation to subclasses.

    //The Factory Method defines an interface for creating objects,
    //but lets subclasses decide which classes to instantiate.
    //Injection molding presses demonstrate this pattern.
    //Manufacturers of plastic toys process plastic molding powder,
    //and inject the plastic into molds of the desired shapes.
    //The class of toy (car, action figure, etc.) is determined by the mold.
    public class FactoryExample
    {

        public void ToyFactoryExample()
        {
            ToyCreator[] creators = new ToyCreator[2];
            creators[0] = new CarToyCreator();
            creators[1] = new DuckToyCreator();

            // Iterate over creators and create products
            foreach (ToyCreator creator in creators)
            {
                Toy toy = creator.CreateToy();
                Console.WriteLine("Created {0}", toy.GetType().Name);
            }
            // Wait for user
            Console.ReadKey();
        }
    }

    public abstract class Toy
    {
    }
    public class CarToy : Toy
    {
    }
    public class DuckToy : Toy
    {
    }

    public abstract class ToyCreator
    {
        public abstract Toy CreateToy();
    }
    public class CarToyCreator : ToyCreator
    {
        public override Toy CreateToy()
        {
            return new CarToy();
        }
    }
    public class DuckToyCreator : ToyCreator
    {
        public override Toy CreateToy()
        {
            return new DuckToy();
        }
    }

}
