
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
            Jet jet = new Jet();
            jet.setGoAlgorithm(new GoByDriving());
            Console.WriteLine(jet.go());
            jet.setGoAlgorithm(new GoByFlyingFast());
            Console.WriteLine(jet.go());
            jet.setGoAlgorithm(new GoByDriving());
            Console.WriteLine(jet.go());
            Console.ReadLine();
        }
    }


    //Different strategy inherited from different 
    public interface IGoAlgorithm
    {
        string Go();
    }
    public class GoByDriving : IGoAlgorithm
    {
        public string Go()
        {
            return "Go By Driving";
        }
    }
    public class GoByFlying : IGoAlgorithm
    {
        public string Go()
        {
            return "Go By Flying";
        }
    }
    public class GoByFlyingFast : IGoAlgorithm
    {
        public string Go()
        {
            return "Go By Flying Fast";
        }
    }




    //Abstract strategy
    public abstract class DrivingStrategy
    {
        private IGoAlgorithm _goAlgorithm;
        public void setGoAlgorithm(IGoAlgorithm algorithm)
        {
            _goAlgorithm = algorithm;
        }
        public string go()
        {
            return _goAlgorithm.Go();
        }

    }
    public class StreetRacer : DrivingStrategy
    {
        public StreetRacer()
        {
            setGoAlgorithm(new GoByDriving());
        }
    }

    public class FormulaOne : DrivingStrategy
    {
        public FormulaOne()
        {
            setGoAlgorithm(new GoByDriving());
        }
    }

    public class Helicopter : DrivingStrategy
    {
        public Helicopter()
        {
            setGoAlgorithm(new GoByFlying());
        }
    }

    public class Jet : DrivingStrategy
    {
        public Jet()
        {
            setGoAlgorithm(new GoByFlyingFast());
        }
    }

}
