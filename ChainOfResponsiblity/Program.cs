using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsiblity
{
    class Program
    {
        static void Main(string[] args)
        {
            int FRONT_END_HELP = 1;
            int INTERMEDIATE_LAYER_HELP = 2;
            int GENERAL_HELP = 3;
            Application app = new Application();
            IntermediateLayer intermediateLayer = new IntermediateLayer(app);
            FrontEnd frontEnd = new FrontEnd(intermediateLayer);
            frontEnd.getHelp(GENERAL_HELP);
            Console.ReadLine();
        }
    }
}
