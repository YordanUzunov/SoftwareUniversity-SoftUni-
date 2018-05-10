namespace _05._Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            List<int> addMany = new List<int>();

            while (commands[0] != "print")
            {
                addMany.Clear();

                if (commands[0] == "add")
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);
                    nums.Insert(index, element);
                }
                else if (commands[0] == "addMany")
                {
                    int index = int.Parse(commands[1]);
                    for (int i = 2; i < commands.Count; i++)
                    {
                        int currentElement = 0;
                        currentElement = int.Parse(commands[i]);
                        addMany.Insert(i - 2, currentElement);
                    }
                    AddToList(addMany, nums, index);
                }
                else if (commands[0] == "contains")
                {
                    int element = int.Parse(commands[1]);
                    if (nums.Contains(element))
                    {
                        Console.WriteLine(nums.IndexOf(element));
                    }
                    else Console.WriteLine("-1");
                }
                else if (commands[0] == "remove")
                {
                    int element = int.Parse(commands[1]);
                    nums.RemoveAt(element);
                }
                else if (commands[0] == "shift")
                {
                    int element = int.Parse(commands[1]);
                    for (int i = 0; i < element; i++)
                    {
                        int first = nums[0];
                        nums.RemoveAt(0);
                        nums.Add(first);
                    }
                }
                else if (commands[0] == "sumPairs")
                {
                    for (int i = 0; i <= nums.Count / 2; i++)
                    {
                        int element = nums[i] + nums[i + 1];
                        nums.RemoveRange(i, 2);
                        nums.Insert(i, element);
                    }
                }

                commands = Console.ReadLine().Split(' ').ToList();
            }

            if (commands[0] == "print") Console.WriteLine("[{0}]", string.Join(", ", nums));
        }

        private static void AddToList(List<int> addMany, List<int> nums, int index)
        {
            for (int i = 0; i < addMany.Count; i++)
            {
                nums.Insert(index + i, addMany[i]);
            }
        }
    }
}
