namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Contracts;
    using PhotoShare.Services.Contracts;
    using PhotoShare.Client.Core.Dtos;
    using PhotoShare.Models.Enums;

    public class ShareAlbumCommand : ICommand
    {
        private const string SuccessfullyShared = "Username {0} added to album {1} ({2})";
        private const string InvalidAlbum = "Album {0} not found!";
        private const string InvalidUser = "User {0} not found!";
        private const string InvalidPermissionType = "Permission must be either “Owner” or “Viewer”!";
        private const string InvalidCredentials = "Invalid credentials.";

        private readonly IUserSessionService userSessionService;
        private readonly IAlbumRoleService albumRoleService;
        private readonly IAlbumService albumService;
        private readonly IUserService userService;

        public ShareAlbumCommand(IUserSessionService userSessionService, IAlbumRoleService albumRoleService, IAlbumService albumService, IUserService userService)
        {
            this.userSessionService = userSessionService;
            this.albumRoleService = albumRoleService;
            this.albumService = albumService;
            this.userService = userService;
        }

        // ShareAlbum <albumId> <username> <permission>
        // Makes specified user to be part of given album.
        public string Execute(string[] data)
        {
            var albumId = int.Parse(data[0]);
            var username = data[1];
            var permission = data[2];

            this.ValidateUser(username);
            this.ValidateAlbum(albumId);
            this.ValidateRole(permission);

            var userId = this.userService.ByUsername<UserDto>(username).Id;
            var albumTitle = this.albumService.ById<AlbumDto>(albumId).Name;

            this.CheckIfLoggedInAndIsOwner(albumTitle, permission);

            this.albumRoleService.PublishAlbumRole(albumId, userId, permission);

            return string.Format(SuccessfullyShared, username, albumTitle, permission);
        }

        private void ValidateUser(string username)
        {
            if (!this.userService.Exists(username))
            {
                throw new ArgumentException(string.Format(InvalidUser, username));
            }
        }

        private void ValidateAlbum(int albumId)
        {
            if (!this.albumService.Exists(albumId))
            {
                throw new ArgumentException(string.Format(InvalidAlbum, albumId));
            }
        }

        private void ValidateRole(string permission)
        {
            Role role;

            if (!Enum.TryParse(permission, out role))
            {
                throw new ArgumentException(string.Format(InvalidPermissionType, permission));
            }
        }

        private void CheckIfLoggedInAndIsOwner(string albumName, string permission)
        {
            var isLoggedIn = this.userSessionService.IsLoggedIn();

            var isOwner = permission.Equals("Owner");

            if (!isLoggedIn || !isOwner)
            {
                throw new InvalidOperationException(InvalidCredentials);
            }
        }
    }
}