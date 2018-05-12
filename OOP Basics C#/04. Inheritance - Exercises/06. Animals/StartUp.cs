namespace P06_Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var animals = GetAnimals();
            Console.WriteLine(string.Join(Environment.NewLine, animals));
        }

        private static Queue<Animal> GetAnimals()
        {
            var animals = new Queue<Animal>();
            while (true)
            {
                var animalType = Console.ReadLine();
                if (animalType == "Beast!")
                {
                    break;
                }

                var animalArgs = Console.ReadLine().Split();
                var name = animalArgs[0];
                var age = int.Parse(animalArgs[1]);
                var gender = animalArgs[2];

                try
                {
                    var animal = AnimalFactory.GetAnimal(animalType, name, age, gender);
                    animals.Enqueue(animal);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                continue;
            }

            return animals;
        }
    }
}
