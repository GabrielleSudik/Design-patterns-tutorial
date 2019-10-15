using Interfaces;
using Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory

//prof says the Abstract Factory pattern is basically the Factory Patter,
//but abstracted again. Think of it as a factory of factoryies.
//That makes sense, but tbh I didn't really follow the explanation in the code.

{
    class Program
    {
        static void Main(string[] args)
        {
            //create some account numbers
            //pass it to the factory to determine which bank will be used
            //and then it creates a loan and a savings for each bank.
            //returns the error message for Chase.
            List<string> accntNumbers = new List<string> {
                                        "CITI-456",
                                        "NATIONAL-987",
                                        "CHASE-222" };
            for (int i = 0; i < accntNumbers.Count; i++)
            {
                ICreditUnionFactory anAbstractFactory =
                    CreditUnionFactoryProvider.
                    GetCreditUnionFactory(accntNumbers[i]);
                if (anAbstractFactory == null)
                {
                    Console.WriteLine("Sorry. This credit union w/ account number" +
                                      " ' {0} ' is invalid.", (accntNumbers[i]));
                }
                else
                {
                    ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
                    ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
                }
            }
            Console.ReadLine();

        }
    }
}
