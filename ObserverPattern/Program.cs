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
            //Registered the observers
            Archiver archiver = new Archiver();
            Client client = new Client();
            Boss boss = new Boss();

            //Main subject
            Database database = new Database();
            database.registerObserver(archiver);
            database.registerObserver(client);
            database.registerObserver(boss);

            //Any event
            database.editRecord("delete", "record 1");

            Console.WriteLine("Removing the archiever from the notifications");
            database.removeObserver(archiver);
            database.editRecord("update", "record 2");

            Console.WriteLine("\n");



            Console.ReadLine();


        }
    }
}
