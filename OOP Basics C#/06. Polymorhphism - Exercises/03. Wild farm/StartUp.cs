namespace P03_Wildfarm
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var animals = new List<IAnimal>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var animalArgs = inputLine.Split();
                var foodArgs = Console.ReadLine().Split();

                try
                {
                    Animal animal = AnimalFactory.GetAnimal(animalArgs);
                    animals.Add(animal);

                    Food food = FoodFactory.GetFood(foodArgs);

                    Console.WriteLine(animal.ProduceSound());
                    animal.IncreaseWeight(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }   
    }
}
