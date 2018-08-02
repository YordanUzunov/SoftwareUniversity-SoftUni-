using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Services.Contracts;
using System;

namespace PhotoShare.Client.Core.Commands
{
    public class LoginCommand : ICommand
    {
        private const string SuccessfullyLoggedInUser = "User {0} successfully logged in.";
        private const string InvalidUsernameOrPassword = "Invalid username or password.";
        private const string AlreadyLoggedInUser = "You should logout first.";
        private const string InvalidCredentials = "Invalid credentials.";

        private readonly IUserService userService;
        private readonly IUserSessionService userSessionService;

        public LoginCommand(IUserService userService, IUserSessionService userSessionService)
        {
            this.userService = userService;
            this.userSessionService = userSessionService;
        }

        // Login <username> <password>
        // Logs a user into the system and keep a reference to it until the “Logout” command is called.
        public string Execute(string[] args)
        {
            var username = args[0];
            var password = args[1];

            this.ValidateUsernameAndPassword(username, password);
            this.userSessionService.LogIn(username);

            return string.Format(SuccessfullyLoggedInUser, username);
        }

        private void ValidateUsernameAndPassword(string username, string password)
        {
            var usernameExists = this.userService.Exists(username);

            if (!usernameExists)
            {
                throw new ArgumentException(InvalidUsernameOrPassword);
            }

            var userDto = this.userService.ByUsername<UserDto>(username);
            var passwordMatches = userDto.Password.Equals(password);

            if (!passwordMatches)
            {
                throw new ArgumentException(InvalidUsernameOrPassword);
            }
        }

        private void CheckIfAlreadyLoggedIn()
        {
            var loggedIn = this.userSessionService.IsLoggedIn();

            if (loggedIn)
            {
                throw new ArgumentException(AlreadyLoggedInUser);
            }
        }
    }
}
