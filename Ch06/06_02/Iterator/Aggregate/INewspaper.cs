﻿using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Aggregate
{
    // Aggregate
    //start here
    public interface INewspaper
    {
        IIterator CreateIterator();
        //here's the I version of CreateIterator.
        //both LAPaper and NYPaper implement this, but slightly differently.
        //one does a list, one does an array.
    }
}
