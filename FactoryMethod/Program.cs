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
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[3];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();
            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
            // Wait for user
            Console.ReadKey();
        }
    }

    public abstract class Product
    {
    }
    public class ConcreteProductA : Product
    {
    }
    public class ConcreteProductB : Product
    {
    }



    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }



}
