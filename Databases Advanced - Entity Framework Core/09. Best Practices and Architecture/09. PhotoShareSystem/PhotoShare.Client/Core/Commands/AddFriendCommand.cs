namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Contracts;
    using PhotoShare.Services.Contracts;
    using PhotoShare.Client.Core.Dtos;
    using System.Linq;

    public class AddFriendCommand : ICommand
    {
        private const string SuccessfullyAddedFriend = "Friend {0} added to {1}.";
        private const string UserNotFound = "User {0} not found.";
        private const string AlreadyFriends = "{0} is already a friend to {1}.";
        private const string AlreadySentRequest = "Request is already sent.";
        private const string InvalidCredentials = "Invalid credentials.";

        private readonly IUserSessionService userSessionService;
        private readonly IUserService userService;

        public AddFriendCommand(IUserSessionService userSessionService, IUserService userService)
        {
            this.userSessionService = userSessionService;
            this.userService = userService;
        }

        // AddFriend <username1> <username2>
        // The first user adds the second one as a friend. 
        public string Execute(string[] data)
        {
            var username = data[0];
            var friendUsername = data[1];

            this.ValidateUsernames(username, friendUsername);
            this.CheckIfLoggedIn(username);

            var userFrindsDto = this.userService.ByUsername<UserFriendsDto>(username);
            var friendFriendsDto = this.userService.ByUsername<UserFriendsDto>(friendUsername);

            this.CheckIfAlreadyFriends(userFrindsDto, friendFriendsDto);

            this.userService.AddFriend(userFrindsDto.Id, friendFriendsDto.Id);

            return string.Format(SuccessfullyAddedFriend, username, friendUsername);
        }

        private void ValidateUsernames(string username, string friendUsername)
        {
            if (!this.userService.Exists(username))
            {
                throw new ArgumentException(string.Format(UserNotFound, username));
            }

            if (!this.userService.Exists(friendUsername))
            {
                throw new ArgumentException(string.Format(UserNotFound, friendUsername));
            }
        }

        private void CheckIfLoggedIn(string username)
        {
            var isLoggedIn = this.userSessionService.IsLoggedIn();
            var isThisUserLoggedIn = this.userSessionService.GetUsername().Equals(username);

            if (!isLoggedIn || !isThisUserLoggedIn)
            {
                throw new InvalidOperationException(InvalidCredentials);
            }
        }

        private void CheckIfAlreadyFriends(UserFriendsDto userFrindsDto, UserFriendsDto friendFriendsDto)
        {
            var userHasSentRequest = userFrindsDto.Friends.Any(f => f.Id.Equals(friendFriendsDto.Id));
            var friendHasSentRequest = friendFriendsDto.Friends.Any(f => f.Id.Equals(userFrindsDto.Id));

            if (userHasSentRequest && friendHasSentRequest)
            {
                throw new InvalidOperationException(string.Format(AlreadyFriends, friendHasSentRequest, userHasSentRequest));
            }
            if (userHasSentRequest && !friendHasSentRequest || !userHasSentRequest && friendHasSentRequest)
            {
                throw new InvalidOperationException(AlreadySentRequest);
            }
        }
    }
}