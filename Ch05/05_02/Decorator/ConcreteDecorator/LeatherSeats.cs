using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
    public class LeatherSeats : CarDecorator
    {
        //the constructor. it sets Leather Seats.
        public LeatherSeats(Car car) : base(car)
        {
            Description = "Leather Seats";
        }

        //this code passes in the description, ie Leather Seats,
        //plus whatever other Description comes from other places.
        public override string GetDescription() => 
                               $"{_car.GetDescription()},  {Description}";

        //and this code, which adds 2500 to whatever the price
        //already is from other sources.
        public override double GetCarPrice() => _car.GetCarPrice() + 2500;
    }
}
