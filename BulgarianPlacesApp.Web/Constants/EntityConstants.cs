﻿namespace BulgarianPlacesApp.Web.Constants
{
    public class EntityConstants
    {
        // ApplicationUser Entity Constants
        public static class User
        {
            public const int BioMinLength = 10;
            public const int BioMaxLength = 500;
            //public const string DefaultProfilePictureURL = "/images/default-profile.png";
        }

        // LocationPost Entity Constants
        public static class LocationPost
        {
            public const int TitleMinLength = 5;
            public const int TitleMaxLength = 150;
            public const int DescriptionMinLength = 20;
            public const int DescriptionMaxLength = 2000;

        }

        // Location Entity Constants
        public static class Location
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 100;
        }

        // Comment Entity Constants
        public static class Comment
        {
            public const int ContentMinLength = 5;
            public const int ContentMaxLength = 300;
        }

        // Tag Entity Constants
        public static class Tag
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

        }
    }
}