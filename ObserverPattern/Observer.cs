//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//// Observer pattern is used when there is one-to-many relationship between objects such as if one object is modified,
//// its depenedent objects are to be notified automatically
//namespace ObserverPattern
//{
//    // Subject Interface
//    public interface ISubject
//    {
//        void registerObserver(IObserver o);
//        void removeObserver(IObserver o);
//        void notifyObservers();
//    }

//    // Observer Interface
//    public interface IObserver
//    {
//        void update(String operation, String record);
//    }

//    // Concrete Subject
//    public class Database : ISubject
//    {
//        private List<IObserver> _observers;
//        private string _operation;
//        private string _record;

//        public Database()
//        {
//            _observers = new List<IObserver>();
//        }

//        public void notifyObservers()
//        {
//            foreach (var observer in _observers)
//            {
//                observer.update(_operation, _record);
//            }
//        }

//        public void registerObserver(IObserver o)
//        {
//            _observers.Add(o);
//        }

//        public void removeObserver(IObserver o)
//        {
//            _observers.Remove(o);
//        }

//        public void editRecord(string operation, string record)
//        {
//            this._operation = operation;
//            this._record = record;
//            notifyObservers();
//        }
//    }

//    // Concrete Observer 1
//    public class Archiver : IObserver
//    {
//        public Archiver()
//        {
//        }
//        public void update(string operation, string record)
//        {
//            Console.WriteLine("The archiver says " + operation + " operation was performed on " + record);
//        }
//    }

//    // Concrete Observer 2
//    public class Client : IObserver
//    {
//        public Client()
//        {
//        }
//        public void update(string operation, string record)
//        {
//            Console.WriteLine("The client says " + operation + " operation was performed on " + record);
//        }
//    }

//    // Concrete Observer 3
//    public class Boss : IObserver
//    {
//        public Boss()
//        {
//        }
//        public void update(string operation, string record)
//        {
//            Console.WriteLine("The boss says " + operation + " operation was performed on " + record);
//        }
//    }
//}
