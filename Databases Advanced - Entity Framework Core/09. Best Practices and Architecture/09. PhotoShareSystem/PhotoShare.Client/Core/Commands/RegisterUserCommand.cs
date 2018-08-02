namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Contracts;
    using PhotoShare.Services.Contracts;

    public class RegisterUserCommand : ICommand
    {
        private const string SuccessfullyRegisteredUser = "User {0} was registered successfully.";
        private const int ArgumentsCount = 4;
        private const string InvalidCommand = "Command RegisterUser not valid.";
        private const string UnmatchedPasswords = "Passwords do not match.";
        private const string UsernameIsTaken = "Username {0} is already taken.";
        private const string InvalidCredentials = "Invalid credentials.";

        private readonly IUserSessionService userSessionService;
        private readonly IUserService userService;

        public RegisterUserCommand(IUserSessionService userSessionService, IUserService userService)
        {
            this.userSessionService = userSessionService;
            this.userService = userService;
        }

        // RegisterUser <username> <password> <repeat-password> <email>
        // Registers a new user.
        public string Execute(string[] data)
        {
            this.ValidateArgumentsCount(data);

            var username = data[0];
            var password = data[1];
            var repeatPassword = data[2];
            var email = data[3];

            this.CheckIfLoggedOut();

            this.ValidateUsername(username);
            this.ValidatePasswordMatch(password, repeatPassword);

            this.userService.Register(username, password, email);

            return string.Format(SuccessfullyRegisteredUser, username);
        }

        private void ValidateArgumentsCount(string[] data)
        {
            if (!data.Length.Equals(ArgumentsCount))
            {
                throw new ArgumentException(InvalidCommand);
            }
        }

        private void CheckIfLoggedOut()
        {
            var loggedIn = this.userSessionService.IsLoggedIn();

            if (loggedIn)
            {
                throw new InvalidOperationException(InvalidCredentials);
            }
        }

        private void ValidateUsername(string username)
        {
            if (this.userService.Exists(username))
            {
                throw new InvalidOperationException(string.Format(UsernameIsTaken, username));
            }
        }

        private void ValidatePasswordMatch(string password, string repeatPassword)
        {
            if (!password.Equals(repeatPassword))
            {
                throw new ArgumentException(UnmatchedPasswords);
            }
        }

    }
}