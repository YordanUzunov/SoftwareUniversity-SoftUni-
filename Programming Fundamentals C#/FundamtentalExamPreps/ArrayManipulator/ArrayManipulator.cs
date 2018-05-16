using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();
            while (command != "end")
            {
                var tokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var arrComand = tokens[0];
                switch (arrComand)
                {
                    case "exchange":
                        {
                            var index = int.Parse(tokens[1]);
                            if (index < -1 || index > numbersList.Count - 1)
                            {
                                Console.WriteLine("Invalid index");
                                break;
                            }
                            else if (index == -1 || index == numbersList.Count - 1)
                            {
                                break;
                            }
                            else
                            {
                                var numbersToMove = numbersList.Skip(index + 1).Take(numbersList.Count - (index + 1)).ToArray();
                                numbersList.RemoveRange(index + 1, numbersList.Count - (index + 1));
                                numbersList.InsertRange(0, numbersToMove);
                            }
                            break;
                        }
                    case "max":
                        {
                            var evenOrOdd = tokens[1];
                            if (evenOrOdd == "odd")
                            {
                                if (!numbersList.Any(x => x % 2 != 0))
                                {
                                    Console.WriteLine("No matches");
                                    break;
                                }
                                else
                                {
                                    int maxNum = numbersList.Where(x => x % 2 != 0).Max();
                                    var lastIndex = numbersList.LastIndexOf(maxNum);
                                    Console.WriteLine(lastIndex);
                                    break;
                                }
                            }
                            else if (evenOrOdd == "even")
                            {
                                if (!numbersList.Any(x => x % 2 == 0))
                                {
                                    Console.WriteLine("No matches");
                                    break;
                                }
                                else
                                {
                                    int maxNum = numbersList.Where(x => x % 2 == 0).Max();
                                    var lastIndex = numbersList.LastIndexOf(maxNum);
                                    Console.WriteLine(lastIndex);
                                    break;
                                }
                            }
                            break;
                        }
                    case "min":
                        {
                            var evenOrOdd = tokens[1];
                            if (evenOrOdd == "odd")
                            {
                                if (!numbersList.Any(x => x % 2 != 0))
                                {
                                    Console.WriteLine("No matches");
                                    break;
                                }
                                else
                                {
                                    int minNum = numbersList.Where(x => x % 2 != 0).Min();
                                    var lastIndex = numbersList.LastIndexOf(minNum);
                                    Console.WriteLine(lastIndex);
                                    break;
                                }
                            }
                            else if (evenOrOdd == "even")
                            {
                                if (!numbersList.Any(x => x % 2 == 0))
                                {
                                    Console.WriteLine("No matches");
                                    break;
                                }
                                else
                                {
                                    int minNum = numbersList.Where(x => x % 2 == 0).Min();
                                    var lastIndex = numbersList.LastIndexOf(minNum);
                                    Console.WriteLine(lastIndex);
                                    break;
                                }
                            }
                            break;
                        }
                    case "first":
                        {
                            int count = int.Parse(tokens[1]);
                            if (count > numbersList.Count) { Console.WriteLine("Invalid count"); break; }
                            var evenOrOdd = tokens[2];
                            if (evenOrOdd == "odd")
                            {
                                if (!numbersList.Any(x => x % 2 != 0))
                                {
                                    Console.WriteLine("[]");
                                    break;
                                }
                                else
                                {
                                    var oddsArray = numbersList.Where(x => x % 2 != 0).ToArray();
                                    if (count >= oddsArray.Length)
                                    {
                                        Console.WriteLine($"[{string.Join(", ", oddsArray)}]");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"[{string.Join(", ", oddsArray.Take(count))}]");
                                    }
                                    break;
                                }
                            }
                            else if (evenOrOdd == "even")
                            {
                                if (!numbersList.Any(x => x % 2 == 0))
                                {
                                    Console.WriteLine("[]");
                                    break;
                                }
                                else
                                {
                                    var evensArray = numbersList.Where(x => x % 2 == 0).ToArray();
                                    if (count >= evensArray.Length)
                                    {
                                        Console.WriteLine($"[{string.Join(", ", evensArray)}]");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"[{string.Join(", ", evensArray.Take(count))}");
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                    case "last":
                        {
                            int count = int.Parse(tokens[1]);
                            if (count > numbersList.Count) { Console.WriteLine("Invalid count"); break; }
                            var evenOrOdd = tokens[2];
                            if (evenOrOdd == "odd")
                            {
                                if (!numbersList.Any(x => x % 2 != 0))
                                {
                                    Console.WriteLine("[]");
                                    break;
                                }
                                else
                                {
                                    var oddsArray = numbersList.Where(x => x % 2 != 0).ToArray();
                                    if (count >= oddsArray.Length)
                                    {
                                        Console.WriteLine($"[{string.Join(", ", oddsArray)}]");
                                    }
                                    else
                                    {
                                        var diff = oddsArray.Length - count;
                                        Console.WriteLine($"[{string.Join(", ", oddsArray.Skip(diff).Take(count))}]");
                                    }
                                    break;
                                }
                            }
                            else if (evenOrOdd == "even")
                            {
                                if (!numbersList.Any(x => x % 2 == 0))
                                {
                                    Console.WriteLine("[]");
                                    break;
                                }
                                else
                                {
                                    var evensArray = numbersList.Where(x => x % 2 == 0).ToArray();
                                    if (count >= evensArray.Length)
                                    {
                                        Console.WriteLine($"[{string.Join(", ", evensArray)}]");
                                    }
                                    else
                                    {
                                        var diff = evensArray.Length - count;
                                        Console.WriteLine($"[{string.Join(", ", evensArray.Skip(diff).Take(count))}");
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbersList)}]");
        }
        
    }
}
