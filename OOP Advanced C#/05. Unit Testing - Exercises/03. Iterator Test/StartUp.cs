namespace P03_IteratorTest
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            ExecuteCommands();
        }

        private static void ExecuteCommands()
        {
            var initializationArgs = Console.ReadLine().Split();
            var iterator = new ListIterator(initializationArgs.Skip(1));

            var iteratorMethods = iterator.GetType().GetMethods();

            var command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    var parsedMethod = iteratorMethods.FirstOrDefault(m => m.Name == command);

                    if (parsedMethod == null)
                    {
                        Console.WriteLine($"This option {command} does not exist");
                    }

                    Console.WriteLine(parsedMethod.Invoke(iterator, new object[] { }));
                }
                catch (TargetInvocationException tie)
                {
                    if(tie.InnerException is InvalidOperationException)
                    {
                        Console.WriteLine(tie.InnerException.Message);
                    }
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.Message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
