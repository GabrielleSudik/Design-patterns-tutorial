using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    // Component
    //while it's abstract, think of this as the main thing.
    //the implementations of abstract Car are found in
    //ConcreteComponent: CompactCar and FullSizeCar

    public abstract class Car
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double GetCarPrice();
    }
}
