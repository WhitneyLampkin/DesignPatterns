using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.StrategyPattern
{
    /// <summary>
    /// Mallard duck subclass
    /// </summary>
    public class MallardDuck : Duck
    {
        /// <summary>
        /// A MallardDuck uses the Quack class to handle its quack,
        /// so when performQuack is called, the responsibility for
        /// the quack is delegated to the Quack object and we get a real quack.
        /// And it uses FlyWithWings as its IFlyBehavior.
        /// </summary>
        public MallardDuck()
        {
            // These two instance variables are inherited from the Duck superclass.
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}