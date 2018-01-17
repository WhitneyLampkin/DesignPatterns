using DesignPatterns.StrategyPattern;
using StrategyPattern.Behaviors;
using StrategyPattern.Behaviors.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}
