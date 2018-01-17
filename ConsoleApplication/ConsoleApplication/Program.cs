using DesignPatterns.StrategyPattern;
using StrategyPattern.Behaviors.FlyBehaviors;
using StrategyPattern.Ducks;
using System;

namespace MiniDuckSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Mallard Duck Example
            Console.WriteLine("Running the mallard duck example...");
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            Console.WriteLine();

            // Model duck example that changes the duck's fly behavior at runtime
            // by calling its setter method for the fly behavior.
            Console.WriteLine("Running the model duck example...");
            Duck model = new ModelDuck();
            model.PerformQuack();

            // This first call to PerformFly() delegates to the flyBehavior object 
            // set in the ModelDuck's constructor, which is a FlyNoWay instance.  
            model.PerformFly();

            // To change a duck's behavior at runtime, just call the duck's setter
            // method for that behavior (see next example).

            // This invokes the model's inherited behavior setter method, and voila!
            // The model suddenly has rocket-powered flying capability!
            model.SetFlyBehavior(new FlyRocketPowered());

            // If it worked, the model duck dynamically changes its flying behavior!
            // You can't do that if the implementation lives inside the duck class.
            model.PerformFly();

            Console.ReadLine();
        }
    }
}
