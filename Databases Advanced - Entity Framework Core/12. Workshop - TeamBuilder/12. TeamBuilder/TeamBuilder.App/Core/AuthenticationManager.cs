﻿namespace TeamBuilder.App.Core
{
    using System;

    using TeamBuilder.Models;

    public class AuthenticationManager
    {
        private static User currentUser;

        public static void Login(User user)
        {
            if (currentUser != null)
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LogoutFirst);
            }

            currentUser = user;
        }

        public static void Logout()
        {
            Authorize();
            currentUser = null;
        }

        public static void Authorize()
        {
            if (currentUser == null)
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }
        }

        public static bool IsAuthenticated()
        {
            return currentUser != null ? true : false;
        }

        public static User GetCurrentUser()
        {
            Authorize();
            return currentUser;
        }
    }
}
