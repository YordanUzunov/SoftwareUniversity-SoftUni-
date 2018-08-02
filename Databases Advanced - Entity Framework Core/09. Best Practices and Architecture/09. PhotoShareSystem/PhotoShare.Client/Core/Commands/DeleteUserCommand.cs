namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Dtos;
    using Contracts;
    using Services.Contracts;

    public class DeleteUserCommand : ICommand
    {
        private const string SuccessfullyDeletedUser = "User {0} was deleted successfully.";
        private const string UserNotFound = "User {0} not found.";
        private const string AlreadyDeletedUser = "User {0} is already deleted.";
        private const string InvalidCredentials = "Invalid credentials.";

        private readonly IUserSessionService userSessionService;
        private readonly IUserService userService;

        public DeleteUserCommand(IUserSessionService userSessionService, IUserService userService)
        {
            this.userService = userService;
            this.userService = userService;
        }

        // DeleteUser <username>
        // Deletes a user.
        public string Execute(string[] data)
        {
            string username = data[0];

            this.ValidateUser(username);
            this.CheckIfTheSameUserIsLoggedIn(username);

            this.userService.Delete(username);

            return string.Format(SuccessfullyDeletedUser, username);
        }

        private void ValidateUser(string username)
        {
            var userExists = this.userService.Exists(username);

            if (!userExists)
            {
                throw new ArgumentException(string.Format(UserNotFound, username));
            }

            var user = this.userService.ByUsername<UserDto>(username);

            if (user.IsDeleted.Value)
            {
                throw new InvalidOperationException(string.Format(AlreadyDeletedUser, username));
            }
        }

        private void CheckIfTheSameUserIsLoggedIn(string username)
        {
            var isLoggedIn = this.userSessionService.IsLoggedIn();
            var isTheSameUser = this.userSessionService.GetUsername().Equals(username);

            if (!isLoggedIn || !isTheSameUser)
            {
                throw new InvalidOperationException(InvalidCredentials);
            }
        }
    }
}
