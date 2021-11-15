using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral
{
    //  Define a family of algorithms, 
    //  encapsulate each one, and make them interchangeable.
    //  Strategy lets the algorithm vary independently from clients that use it.    
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

    public abstract class DrivingStrategy
    {
        private IGoAlgorithm _goAlgorithm;
        public DrivingStrategy()
        {
        }
        public void setGoAlgorithm(IGoAlgorithm algorithm)
        {
            _goAlgorithm = algorithm;
        }

        public void go()
        {
            _goAlgorithm.Go();
        }

    }


    // Clients
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

    // Selecting Algorithms at runtime
    public class RealJet
    {
        public static void FlyJet()
        {
            Jet jet = new Jet();
            jet.setGoAlgorithm(new GoByDriving());
            jet.go();
            jet.setGoAlgorithm(new GoByFlyingFast());
            jet.go();
            jet.setGoAlgorithm(new GoByDriving());
            jet.go();
        }
    }

}
