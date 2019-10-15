using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Abstract Factory
    //does two things (each of which is an I itself, down below)
    public abstract class ICreditUnionFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }

    // Abstract Product A
    public interface ILoanAccount { }

    // Abstract Product B
    public interface ISavingsAccount { }
}
