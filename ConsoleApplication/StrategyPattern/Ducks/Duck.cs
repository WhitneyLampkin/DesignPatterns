using StrategyPattern.Interfaces;
using System;

namespace DesignPatterns.StrategyPattern
{
    /// <summary>
    /// Duck superclass 
    /// </summary>
    public abstract class Duck
    {
        /// <summary>
        /// Declare two reference variables for the behavior interface types.
        /// All duck subclasses (in the same package) inherit these.
        /// </summary>
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck()
        {

        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.Write("All ducks float, even decoys!");
        }
    }
}