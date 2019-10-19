using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // Subject
    //step one
    //create an I celebrity class with 3 properies, 2 methods.

    public interface ICelebrity
    {
        string FullName { get; }
        string Tweet { get; set; }
        void Notify(string tweet);
        void AddFollower(IFan fan);
        void RemoveFollower(IFan fan);
    }
}
