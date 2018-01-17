using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Behaviors.QuackBehaviors
{
    /// <summary>
    /// Quack behavior for ducks that do not Quack.
    /// </summary>
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
