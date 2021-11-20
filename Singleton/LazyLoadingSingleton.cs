using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class LazyLoadingSingleton
    {
        private string _name;
        private static Lazy<LazyLoadingSingleton> _lazy = null;
        private LazyLoadingSingleton(string n) { _name = n; }

        public static LazyLoadingSingleton Instance(string parameter)
        {
            if (_lazy == null)
            {
                _lazy = new Lazy<LazyLoadingSingleton>(() => new LazyLoadingSingleton(parameter));
            }
            return _lazy.Value;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
