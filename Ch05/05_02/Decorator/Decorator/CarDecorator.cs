using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    // Decorator
    //like the ConcreteComponents, the decorator also
    //inherits from Car.
    //but it stands alone because you ... well... idk.
    //you can add features to the car and adjust the price
    //to include those features too.

    //I guess it's different from the ConcreteComponents this way:
    //the CCs are always the same for each Compact and FullSize.
    //but you also need a way to price those cars if you, say, 
    //add a sunroof.
    //that's what this decorator does. It will adjust concrete classes
    //to incorporate optional stuff.

    public class CarDecorator : Car
    {
        protected Car _car;
        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override double GetCarPrice() => _car.GetCarPrice();

        public override string GetDescription() => _car.GetDescription();
    }
}
