﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // Concrete Observer
    //step three
    //implement the IFan class
    //just provides info about the tweets "received" from the celebrity.

    public class Fan : IFan
    {
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan notified. Tweet of {celebrity.FullName}: " +
                $"{celebrity.Tweet}");
        }
    }
}
