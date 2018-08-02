namespace PhotoShare.Client.Core.Commands
{
    using System;

    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class LogoutCommand : ICommand
    {
        private const string SuccessfullyLoggedOutUser = "User {0} successfully logged out.";
        private const string NotLoggedInYet = "You should log in first in order to logout.";
        private const string InvalidCredentials = "Invalid credentials.";

        private readonly IUserSessionService userSessionService;

        public LogoutCommand(IUserSessionService userSessionService)
        {
            this.userSessionService = userSessionService;
        }

        // Logout
        // Logs out a user from the system.
        public string Execute(string[] args)
        {
            this.CheckIfUserIsLoggedIn();

            var username = this.userSessionService.GetUsername();

            this.userSessionService.LogOut();

            return string.Format(SuccessfullyLoggedOutUser, username);
        }

        private void CheckIfUserIsLoggedIn()
        {
            var isLoggedIn = this.userSessionService.IsLoggedIn();

            if (!isLoggedIn)
            {
                throw new InvalidOperationException(NotLoggedInYet);
            }
        }
    }
}
