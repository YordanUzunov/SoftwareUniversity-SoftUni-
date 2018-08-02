namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Contracts;

    public class ExitCommand : ICommand
    {

        //Exit
        //Exits application.
        public string Execute(string[] data)
        {
            Environment.Exit(0);
            return "Good Bye!";
        }
    }
}
