using Iterator.Aggregate;
using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        //step five

        static void Main(string[] args)
        {
            //create instances of each paper.
            INewspaper nyt = new NYPaper();
            INewspaper lat = new LAPaper();

            //invoke CreateIterator for each paper.
            //the data for each paper comes from NYPaper and LAPaper
            //but the logic of how the data is presented comes via the iterators.
            //the instance of nyt flags the code to use the NYPaperIterator,
            //and same with lat and LA.
            IIterator nypIterator = nyt.CreateIterator();
            IIterator lapIterator = lat.CreateIterator();

            Console.WriteLine("--------   NYPaper");
            PrintReporters(nypIterator);

            Console.WriteLine("--------   LAPaper");
            PrintReporters(lapIterator);

            Console.ReadLine();
        }

        //the method references the Interface's methods.
        //but the concrete methods will be called to match with the item passed in.
        //ie, NY = nyt, LA = lat.
        static void PrintReporters(IIterator iterator) {
            iterator.First();
            while(!iterator.IsDone()){
                Console.WriteLine(iterator.Next());
            }
        }

        //darn, I thought this pattern would print them all out at once
        //instead it sets up a way to print all collections,
        //regardless of their organization. but not all at once.
    }
}
