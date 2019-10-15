using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton

    //Singletons want to ensure there is only one instance of a class.
{
    public class Program
    {
        static void Main(string[] args)
        {
            //before it's a singleton:
            //create a new instance of the Policy class
            //then assign a name by calling the method in Policy.

            //next step to make it a singleton:
            //1. comment out the creation of the new Policy.
            //var policy = new Policy();

            //2. revise the call to the Policy class,
            //not relying on the "new Policy" created here.
            //var insuredName = policy.GetInsuredName();
            var insuredName = Policy.Instance.GetInsuredName();
            //"Instance" is the important word here.
            //go to Policy class to add it.
            //note Instance is not a keyword; you create that variable.


            Console.WriteLine(insuredName);
        }
    }
}
