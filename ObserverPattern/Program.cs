using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Registered the observers
            //Archiver archiver = new Archiver();
            //Client client = new Client();
            //Boss boss = new Boss();

            ////Main subject
            //Database database = new Database();
            //database.registerObserver(archiver);
            //database.registerObserver(client);
            //database.registerObserver(boss);

            ////Any event
            //database.editRecord("delete", "record 1");

            //Console.WriteLine("Removing the archiever from the notifications");
            //database.removeObserver(archiver);
            //database.editRecord("update", "record 2");

            //Console.WriteLine("\n");

            //Create new instances of observer
            ConcreteObserver1 co1 = new ConcreteObserver1();
            ConcreteObserver2 co2 = new ConcreteObserver2();
            ConcreteObserver3 co3 = new ConcreteObserver3();

            ConcreteSubject cs = new ConcreteSubject();
            cs.registerObserver(co1);
            cs.registerObserver(co2);
            cs.registerObserver(co3);

            cs.AnyEvent();

            cs.removeObserver(co2);

            cs.AnyEvent();

            Console.ReadLine();


        }
    }

    //Observer Interface
    public interface IObserver
    {
        void UpdateObserver();
    }

    //Concrete Observer1

    public class ConcreteObserver1 : IObserver
    {
        public void UpdateObserver() => Console.WriteLine("ConcreteObserver1");
    }

    //Concrete Observer2
    public class ConcreteObserver2 : IObserver
    {
        public void UpdateObserver() => Console.WriteLine("ConcreteObserver2");
    }

    //Concrete Observer3
    public class ConcreteObserver3 : IObserver
    {
        public void UpdateObserver() => Console.WriteLine("ConcreteObserver3");
    }

    //Subject Interface
    public interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservers();
    }

    public class ConcreteSubject : ISubject
    {
        private List<IObserver> _observers;
        public ConcreteSubject() => _observers = new List<IObserver>();
        public void registerObserver(IObserver o) => _observers.Add(o);
        public void removeObserver(IObserver o) => _observers.Remove(o);
        public void notifyObservers() => _observers.ForEach(x => x.UpdateObserver());

        public void AnyEvent() => notifyObservers();
    }
}
