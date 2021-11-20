using DesignPattern.Behavioral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
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
}
