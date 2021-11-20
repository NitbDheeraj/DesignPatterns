using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class ThreadSafeSingleton
    {
        private string _name;

        private static ThreadSafeSingleton _instance = null;

        // Private Constructor
        private ThreadSafeSingleton(string n) { _name = n; }
        private static readonly object _lock = new object();  

        public static ThreadSafeSingleton Instance(string n)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ThreadSafeSingleton(n);
                }
            }
            return _instance;
        }

        //Method to test the name of singleton
        public string GetName()
        {
            return _name;
        }
    }
}
