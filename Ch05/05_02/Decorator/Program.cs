using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator

    //Decorators boil down to wrapping objects.
    //In this coding example, we'll add features to a car.
    //Instead of inheritance, we'll use decorators.

    //note the organization of this code:
    //component = Car
    //decorator = CarDecorator
    //concreteComponent = compact and full size car
    //concreteDecorator = leather, navigation, sunroof
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new CompactCar();//10,000
            theCar = new Navigation(theCar); //5,000
            theCar = new Sunroof(theCar); //2,500
            theCar = new LeatherSeats(theCar); //2,500

            //if you comment out each of Nav/Sun/Leather,
            //you'll see the total price change accordingly.
            //each new decorator/wrapper will add to what was already there.
            //ie, the price, plus whatever the extra cost is.

            Console.WriteLine(theCar.GetDescription());
            Console.WriteLine($"{theCar.GetCarPrice():C2}"); //20,000
            Console.ReadKey();
        }
    }
}
