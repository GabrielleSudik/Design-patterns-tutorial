using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Policy
    {
        //final step:
        //to make the code thread-safe:
        private static readonly object _lock = new object();

        //to make a singleton,
        //instead of instantiating a new Policy in the Program.cs,
        //use a constructor below.

        //this variable is what will ensure it's really single:
        private static Policy _instance;
        //then use it in the getter.

        //and create the definition of Instance:
        //Instance is a variable of the type Policy
        //we really use this to set _instance;
        public static Policy Instance
        {
            get
            {
                //final step: lock the code
                //so two simultaneous threads don't create two instance:
                lock (_lock)
                {                 
                    //this if block is what keeps an instance single
                    //if it already exists.
                    if (_instance == null)
                    { _instance = new Policy(); }

                    return _instance;
                }
            }
        }

        //what that did: if _instance already exists, keep it.
        //if it doesn't, create it.
        //_instance is the "final say" about whether the class
        //has aleady been instantiated.

        //final step: warning! you need to make singleton code thread-safe
        //otherwise, two simultaneous attempts could create two instances.
        //so... we lock the code by adding a private readonly variable.
        //see above.

        //finally, finally:
        //see commented out code at the end of this file
        //for another way to "lock" without using "lock"

        //constructor added:
        public Policy()
        {

        }


        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";

        //method just returns the insured's name
        public string GetInsuredName() => Insured;
    }
}


//instead of using lock around that if block above,
//you could just do this:

    //(no lock code)
    //private static readonly Policy _instance = new Policy();
    //public static Policy Instance {
    //  get { return _instance; }
    //}

//I think what that does is, as soon as _instance is created,
//nothing can change it because it is readonly.