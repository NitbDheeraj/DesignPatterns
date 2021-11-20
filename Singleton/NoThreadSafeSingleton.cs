using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // This is not a thread safe implementation
    public class NoThreadSafeSingleton
    {
        private string _name;

        private static NoThreadSafeSingleton _instance = null;

        // Private Constructor
        private NoThreadSafeSingleton(string n) { _name = n; }

        // Provide a global point of access through a property
        public static NoThreadSafeSingleton Instance(string n)
        {
                if (_instance == null)
                    _instance = new NoThreadSafeSingleton(n);

                return _instance;
        }

        //Method to test the name of singleton
        public string GetName()
        {
            return _name;
        }
    }
}
