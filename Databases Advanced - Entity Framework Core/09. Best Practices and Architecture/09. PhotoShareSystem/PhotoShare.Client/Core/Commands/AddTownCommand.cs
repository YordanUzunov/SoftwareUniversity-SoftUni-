namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Contracts;
    using Services.Contracts;

    public class AddTownCommand : ICommand
    {
        private const string SuccessfullyAddedTown = "Town {0} was added successfully.";
        private const string AlreadyAddedTown = "Town {0} was already added.";
        private const string InvalidCredentials = "Invalid credentials.";

        private readonly IUserSessionService userSessionService;
        private readonly ITownService townService;

        public AddTownCommand(IUserSessionService userSessionService, ITownService townService)
        {
            this.userSessionService = userSessionService;
            this.townService = townService;
        }

        // AddTown <townName> <countryName>
        // Adds new  town. Town names must be unique.
        public string Execute(string[] data)
        {
            string townName = data[0];
            string country = data[1];

            this.CheckIfLoggedIn();
            this.CheckIfTownAlreadyExists(townName);

            this.townService.Add(townName, country);

            return string.Format(SuccessfullyAddedTown, townName);
        }

        private void CheckIfLoggedIn()
        {
            var isLoggedIn = this.userSessionService.IsLoggedIn();

            if (!isLoggedIn)
            {
                throw new InvalidOperationException(InvalidCredentials);
            }
        }

        private void CheckIfTownAlreadyExists(string townName)
        {
            var townExists = this.townService.Exists(townName);

            if (townExists)
            {
                throw new ArgumentException(string.Format(SuccessfullyAddedTown, townName));
            }
        }
    }
}