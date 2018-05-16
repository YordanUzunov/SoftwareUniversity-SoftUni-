using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var removedNumbers = 0;

            while (numbersList.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int value = numbersList[0];
                    removedNumbers += value;
                    numbersList.RemoveAt(0);
                    numbersList.Insert(0, numbersList[numbersList.Count - 1]);
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        if (numbersList[i] <= value)
                        {
                            numbersList[i] += value;
                        }
                        else
                        {
                            numbersList[i] -= value;
                        }
                    }
                }

                if (index > numbersList.Count - 1)
                {
                    int value = numbersList[numbersList.Count - 1];
                    removedNumbers += value;
                    numbersList.RemoveAt(numbersList.Count - 1);
                    numbersList.Add(numbersList[0]);
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        if (numbersList[i] <= value)
                        {
                            numbersList[i] += value;
                        }
                        else
                        {
                            numbersList[i] -= value;
                        }
                    }
                }

                if (index >= 0 && index <= numbersList.Count - 1)
                {
                    int value = numbersList[index];
                    removedNumbers += value;
                    numbersList.RemoveAt(index);
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        if (numbersList[i] <= value)
                        {
                            numbersList[i] += value;
                        }
                        else
                        {
                            numbersList[i] -= value;
                        }
                    }
                }
            }

            Console.WriteLine(removedNumbers);
        }
    }
}
