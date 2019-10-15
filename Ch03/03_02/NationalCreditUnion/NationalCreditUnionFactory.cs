using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalCreditUnion
{
    //two concrete products here:
    //National savings acct and National loan acct

    // ProductA2 (constructor)
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Console.WriteLine("Returned National Savings Account");
        }
    }

    // ProductB2 (constructor)
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
        }
    }

    //the factory to create these concrete products:
    //either National Savings or National Loan.

    // Concrete Factory 2
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            NationalLoanAccount obj = new NationalLoanAccount();
            return obj;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            NationalSavingsAccount obj = new NationalSavingsAccount();
            return obj;
        }
    }
}
