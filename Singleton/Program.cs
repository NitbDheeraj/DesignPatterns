using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            NoThreadSafeSingleton _singleton1 = NoThreadSafeSingleton.Instance("Instance1");

            Console.WriteLine(_singleton1.GetName());

            NoThreadSafeSingleton _singleton2 = NoThreadSafeSingleton.Instance("Instance2");

            Console.WriteLine(_singleton2.GetName());

            Console.WriteLine("\n");
            Console.WriteLine("Testing thread safe singleton");

            Parallel.Invoke(
                () => PrintInstance3(),
                () => PrintInstance4()
                );

            Console.WriteLine("\n");
            Console.WriteLine("Testing Lazy Loading singleton");

            Parallel.Invoke(
                () => PrintInstance5(),
                () => PrintInstance6()
                );

            Console.ReadLine();
        }

        private static void PrintInstance3()
        {
            ThreadSafeSingleton _singleton3 = ThreadSafeSingleton.Instance("Instance3");
            Console.WriteLine(_singleton3.GetName());
        }

        private static void PrintInstance4()
        {
            ThreadSafeSingleton _singleton3 = ThreadSafeSingleton.Instance("Instance4");
            Console.WriteLine(_singleton3.GetName());
        }

        private static void PrintInstance5()
        {
            LazyLoadingSingleton _singleton5 = LazyLoadingSingleton.Instance("Instance5");
            Console.WriteLine(_singleton5.GetName());
        }

        private static void PrintInstance6()
        {
            LazyLoadingSingleton _singleton6 = LazyLoadingSingleton.Instance("Instance6");
            Console.WriteLine(_singleton6.GetName());
        }
    }
}
