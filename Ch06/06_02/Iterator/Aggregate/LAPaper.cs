using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
    // ConcreteAggregate
    //step two
    public class LAPaper : INewspaper
    {        
        private string[] _reporters;  //an array. NYPapter is a list.
        public LAPaper()
        {
            _reporters = new[] { "Ronald Smith - LA",
                                 "Danny Glover - LA",
                                 "Yolanda Adams - LA",
                                 "Jerry Straight - LA",
                                 "Rhonda Lime - LA",
                                };
        }

        public IIterator CreateIterator()
        {
            return new LAPaperIterator(_reporters); 
        }
    }
}
