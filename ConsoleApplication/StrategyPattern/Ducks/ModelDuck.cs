using DesignPatterns.StrategyPattern;
using StrategyPattern.Behaviors;
using StrategyPattern.Behaviors.QuackBehaviors;
using System;

namespace StrategyPattern.Ducks
{
    public class ModelDuck : Duck
    {
        /// <summary>
        /// Model duck subclass
        /// </summary>
        public ModelDuck()
        {
            // The model duck begins like grounded without a way to fly.
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quacks();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}