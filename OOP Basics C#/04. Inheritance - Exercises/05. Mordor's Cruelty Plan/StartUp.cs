namespace P05_MordorsCruelPlan
{
    using Factories;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var gandalf = new Gandalf();
            gandalf.Eat(Console.ReadLine()
                .Split()
                .Where(food => food != string.Empty)
                .Select(food => FoodFactory.GetFood(food)));
            Console.WriteLine(gandalf);
        }
    }
}
