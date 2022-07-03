
using System;

namespace DesignPattern
{
    //  Define a family of algorithms, 
    //  encapsulate each one, and make them interchangeable.
    //  Strategy lets the algorithm vary independently from clients that use it.
    class Program
    {
        static void Main(string[] args)
        {
            // Selecting Algorithms at runtime
            ConcreteStrategy cs = new ConcreteStrategy();
            Console.WriteLine(cs.ImplementAlgorithm());

            cs.SetAlgorithm(new Algorithm2());
            Console.WriteLine(cs.ImplementAlgorithm());

            cs.SetAlgorithm(new Algorithm3());
            Console.WriteLine(cs.ImplementAlgorithm());

  
            Console.ReadLine();
        }
    }


    public interface IAlgorithm
    {
        string Implement();
    }

    public class Algorithm1 : IAlgorithm
    {
        public string Implement() => "Algorithm1";
    }

    public class Algorithm2 : IAlgorithm
    {
        public string Implement() => "Algorithm2";
    }

    public class Algorithm3 : IAlgorithm
    {
        public string Implement() => "Algorithm3";
    }


    //Abstract strategy
    public abstract class Strategy
    {
        private IAlgorithm _algorithm;
        public void SetAlgorithm(IAlgorithm algorithm) => _algorithm = algorithm;
        public string ImplementAlgorithm() => _algorithm.Implement();

    }

    //Concrete Strategy
    public class ConcreteStrategy : Strategy
    {
        public ConcreteStrategy()
        {
            SetAlgorithm(new Algorithm1());
        }
    }

}
