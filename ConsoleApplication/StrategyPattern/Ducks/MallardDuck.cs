using StrategyPattern.Behaviors;
using StrategyPattern.Behaviors.QuackBehaviors;
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
        /// A MallardDuck uses the Quack class to handle its Quack,
        /// so when PerformQuack is called, the responsibility for
        /// the Quack is delegated to the Quack object and we get a real Quack.
        /// And it uses FlyWithWings as its IFlyBehavior.
        /// </summary>
        public MallardDuck()
        {
            // These two instance variables are inherited from the Duck superclass.
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}