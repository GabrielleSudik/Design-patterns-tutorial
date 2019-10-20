using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //the change in one object (the subject/publisher) 
    //causes a change in another object(s) (the observers/subscribers)
    //pretend this project is Twitter.

        //this file comes after everything else.

    class Program
    {
        static void Main(string[] args)
        {
            //invoke instances of each celebrity
            //tbh, I don't know what the strings are for; they don't show up when you run this.
            var gClooney = new GClooney("I love my new wife");
            var tSwift = new TSwift("1981 is now my favorite number.");

            //create two fans
            var firstFan = new Fan();
            var secondFan = new Fan();

            //add them as followers to celebrities
            gClooney.AddFollower(firstFan);
            tSwift.AddFollower(secondFan);

            //make them tweet
            gClooney.Tweet = "My wife didn't force me to tweet.";
            tSwift.Tweet = "I love my new music.";

            //when you run the program, you'll see the property Tweet
            //"sets" the method Notify to run, passing the tweet.
            //Notify targets each fan with Update
            //and Update shows the celebrity's name and their tweet.

            Console.Read();
        }
    }
}
