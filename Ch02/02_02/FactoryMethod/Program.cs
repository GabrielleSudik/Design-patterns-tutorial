using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //pretend two banks merged, with two savings accounts.

            //create a new SavingsAccount.
            //the Factory figures out kind of account to create based on what gets passed to it.

            var factory = new SavingsAcctFactory() as ICreditUnionFactory;
            var citiAcct = factory.GetSavingsAccount("CITI-321");
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");

            Console.WriteLine($"My citi balance is ${citiAcct.Balance}" +
                $" and national balance is ${nationalAcct.Balance}");
        }

    }

    // Product
    //abstract.
    public abstract class ISavingsAccount
    {
        public decimal Balance { get; set; }
    }

    // Concrete Product -- ie, a real type of account
    public class CitiSavingsAcct : ISavingsAccount
    {
        //constructor:
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }

    // Concrete Product -- ie, another type of real account
    public class NationalSavingsAcct : ISavingsAccount
    {
        public NationalSavingsAcct()
        {
            Balance = 2000;
        }
    }

    // Creator -- the I version
    interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNo);
    }

    // Concrete Creators -- implements the I.
    //THIS is the factory. Depending on what you put in (the acctNo),
    //you will get something different out (Citi vs National).
    public class SavingsAcctFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI")) { return new CitiSavingsAcct(); }
            else
            if (acctNo.Contains("NATIONAL")) { return new NationalSavingsAcct(); }
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }
}
