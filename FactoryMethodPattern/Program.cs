using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.Write("Enter the card type you would like to visit: ");
            string car = Console.ReadLine();

            switch (car.ToLower())
            {
                case "a":
                    factory = new CreditCardAFactory();
                    break;
                case "b":
                    factory = new CreditCardBFactory();
                    break;
                case "c":
                    factory = new CreditCardCFactory();
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.ReadKey();

        }
    }

    #region Product Classes

    public abstract class CreditCard
    {
        public abstract string CardType { get; }
    }

    public class CreditCardA : CreditCard
    {
        private readonly string _cardType;

        public CreditCardA()
        {
            _cardType = "Credit Card A";
        }

        public override string CardType
        {
            get { return _cardType; }
        }
    }

    public class CreditCardB : CreditCard
    {
        private readonly string _cardType;

        public CreditCardB()
        {
            _cardType = "Credit Card B";
        }

        public override string CardType
        {
            get { return _cardType; }
        }
    }

    public class CreditCardC : CreditCard
    {
        private readonly string _cardType;

        public CreditCardC()
        {
            _cardType = "Credit Card C";
        }

        public override string CardType
        {
            get { return _cardType; }
        }
    }

    #endregion

    public abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }

    public class CreditCardAFactory : CardFactory
    {

        public override CreditCard GetCreditCard()
        {
            Console.WriteLine("This is Credit Card A");
            return new CreditCardA();
        }
    }

    public class CreditCardBFactory : CardFactory
    {

        public override CreditCard GetCreditCard()
        {
            Console.WriteLine("This is Credit Card B");
            return new CreditCardB();
        }
    }

    public class CreditCardCFactory : CardFactory
    {

        public override CreditCard GetCreditCard()
        {
            Console.WriteLine("This is Credit Card C");
            return new CreditCardC();
        }
    }
}
