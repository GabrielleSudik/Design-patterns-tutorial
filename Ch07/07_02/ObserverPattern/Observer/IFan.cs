using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // Observer
    //step two
    //create the I fan class, with one method.

    public interface IFan
    {
        void Update(ICelebrity celebrity);
    }
}
