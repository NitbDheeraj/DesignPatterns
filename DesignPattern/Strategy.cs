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
      

    //Strategy Interface
    public interface IGoAlgorithm
    {
        string Go();
    }

    //Strategy 1
    public class GoByDriving : IGoAlgorithm
    {
        public string Go()
        {
            return "Go By Driving";
        }
    }

    //Strategy 2
    public class GoByFlying : IGoAlgorithm
    {
        public string Go()
        {
            return "Go By Flying";
        }
    }

    //Strategy 3
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

}
