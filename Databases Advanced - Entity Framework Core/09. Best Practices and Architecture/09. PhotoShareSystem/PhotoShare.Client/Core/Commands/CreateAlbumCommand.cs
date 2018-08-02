namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Contracts;
    using Services.Contracts;
    using System.Linq;
    using PhotoShare.Client.Core.Dtos;
    using PhotoShare.Models.Enums;

    public class CreateAlbumCommand : ICommand
    {
        private const string SuccessfullyCreatedAlbum = "Album {0} successfully created.";
        private const string UserNotFound = "User {0} not found.";
        private const string AlbumAlreadyExists = "Album {0} already exists.";
        private const string ColorNotFound = "Color {0} not found.";
        private const string InvalidTags = "Invalid tags.";
        private const string InvalidCredentials = "Invalid credentials.";

        private readonly IUserSessionService userSessionService;
        private readonly IAlbumService albumService;
        private readonly IUserService userService;
        private readonly ITagService tagService;

        public CreateAlbumCommand(IUserSessionService userSessionService, IAlbumService albumService, IUserService userService, ITagService tagService)
        {
            this.userSessionService = userSessionService;
            this.albumService = albumService;
            this.userService = userService;
            this.tagService = tagService;
        }

        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        // Adds an album. Album names should be unique.
        public string Execute(string[] data)
        {
            var username = data[0];
            var albumTitle = data[1];
            var bgColor = data[2];
            var tags = data.Skip(3).ToArray();

            this.CheckIfLoggedIn();
            this.ValidateUser(username);
            this.ValidateAlbumTitle(albumTitle);
            this.ValidateBgColor(bgColor);
            this.ValidateTags(tags);

            var userId = this.userService.ByUsername<UserDto>(username).Id;

            this.albumService.Create(userId, albumTitle, bgColor, tags);

            return string.Format(SuccessfullyCreatedAlbum, albumTitle);
        }

        private void CheckIfLoggedIn()
        {
            var isLoggedIn = this.userSessionService.IsLoggedIn();

            if (!isLoggedIn)
            {
                throw new InvalidOperationException(InvalidCredentials);
            }
        }

        private void ValidateUser(string username)
        {
            if (!this.userService.Exists(username))
            {
                throw new ArgumentException(string.Format(UserNotFound, username));
            }
        }

        private void ValidateAlbumTitle(string albumTitle)
        {
            if (this.albumService.Exists(albumTitle))
            {
                throw new ArgumentException(string.Format(AlbumAlreadyExists, albumTitle));
            }
        }

        private void ValidateBgColor(string bgColor)
        {
            Color color;

            if (!Enum.TryParse(bgColor, out color))
            {
                throw new ArgumentException(string.Format(ColorNotFound, bgColor));
            }
        }

        private void ValidateTags(string[] tags)
        {
            foreach (var tag in tags)
            {
                if (!this.tagService.Exists(tag))
                {
                    throw new ArgumentException(InvalidTags);
                }
            }
        }
    }
}