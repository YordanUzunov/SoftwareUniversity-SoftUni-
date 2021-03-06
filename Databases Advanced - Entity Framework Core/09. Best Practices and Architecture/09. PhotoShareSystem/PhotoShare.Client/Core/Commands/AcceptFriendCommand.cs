﻿namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Contracts;
    using PhotoShare.Services.Contracts;
    using PhotoShare.Client.Core.Dtos;

    public class AcceptFriendCommand : ICommand
    {
        private const string SuccessfullyAcceptedFriend = "Friend {0} accepted {1} as a friend.";
        private const string UserNotFound = "{0} not found.";
        private const string AlreadyFriends = "{0} is already a friend to {1}.";
        private const string NoFriendRequest = "{0} has not added {1} as a friend.";
        private const string InvalidCredentials = "Invalid credentials.";

        private readonly IUserSessionService userSessionService;
        private readonly IUserService userService;

        public AcceptFriendCommand(IUserSessionService userSessionService, IUserService userService)
        {
            this.userSessionService = userSessionService;
            this.userService = userService;
        }

        // AcceptFriend <username1> <username2>
        public string Execute(string[] data)
        {
            var username = data[0];
            var friendUsername = data[1];

            this.ValidateUsernames(username, friendUsername);
            this.CheckIfLoggedIn(username);

            var userFriendsDto = this.userService.ByUsername<UserFriendsDto>(username);
            var friendFriendsDto = this.userService.ByUsername<UserFriendsDto>(friendUsername);

            this.CheckIfAlreadyFriends(userFriendsDto, friendFriendsDto);

            this.CheckIfThereIfSuchFriendRequest(userFriendsDto, friendFriendsDto);

            this.userService.AcceptFriend(userFriendsDto.Id, friendFriendsDto.Id);

            return string.Format(SuccessfullyAcceptedFriend, username, friendFriendsDto.Username);
        }

        private void ValidateUsernames(string usernameReceivedRequest, string usernameSentRequest)
        {
            if (!this.userService.Exists(usernameReceivedRequest))
            {
                throw new ArgumentException(string.Format(UserNotFound, usernameReceivedRequest));
            }

            if (!this.userService.Exists(usernameSentRequest))
            {
                throw new ArgumentException(string.Format(UserNotFound, usernameSentRequest));
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

        private void CheckIfThereIfSuchFriendRequest(UserFriendsDto user, UserFriendsDto friend)
        {
            var friendHasSentRequest = friend.Friends.Any(f => f.Username.Equals(user.Username)); 

            if (!friendHasSentRequest)
            {
                throw new InvalidOperationException(string.Format(NoFriendRequest, friend.Username, user.Username));
            }
        }

        private void CheckIfAlreadyFriends(UserFriendsDto user, UserFriendsDto friend)
        {
            var userHasSentRequest = user.Friends.Any(f => f.Id.Equals(friend.Id)); 
            var friendHasSentRequest = friend.Friends.Any(f => f.Id.Equals(user.Id)); 

            if (userHasSentRequest && friendHasSentRequest)
            {
                throw new InvalidOperationException(string.Format(AlreadyFriends, friend.Username, user.Username));
            }
        }
    }
}