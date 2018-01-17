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

        public void Swim()
        {
            Console.Write("All ducks float, even decoys!");
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        // Used to change the fly behavior at anytime.
        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        // Used to change the Quack behavior at anytime.
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}