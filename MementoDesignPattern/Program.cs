using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    // A Way to store the previous state of objects easily

    // Memento: The basic object that is stored in different states

    // Originator: Sets and gets values from currently targeted memento. Creates new memento and assigns current values to them

    // Caretaker: Holds an arraylist that contains all previous versions of the memento. It can store and retrieve stored memento

    class Program
    {
        static void Main(string[] args)
        {


        }
    }


    public class Memento
    {
        private string _article;

        public Memento(string articleSave)
        {
            _article = articleSave;
        }

        public string GetSavedArticle() => _article;
    }

    public class Originator
    {
        private string _article;

        public void set(string article)
        {
            Console.WriteLine("Current version of article in originator : " + article);
            _article = article;
        }

        public Memento StoreInMemento()
        {
            Console.WriteLine("Saving to memento in originator");
            return new Memento(_article);
        }

        public string RestoreFromMemento(Memento memento)
        {
            _article = memento.GetSavedArticle();
            Console.WriteLine("From Originator, previous article saved in memento" + _article);
            return _article;
        }
    }

    public class Caretaker
    {
        List<Memento> _savedArticles = new List<Memento>();

        public void AddMemento(Memento m) => _savedArticles.Add(m);

        public Memento GetMemento(int index) => _savedArticles[index];
    }

}
