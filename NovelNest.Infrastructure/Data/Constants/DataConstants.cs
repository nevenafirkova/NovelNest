﻿namespace NovelNest.Infrastructure.Data.Constants
{
    public static class DataConstants
    {
        public const string DateTimeDefaultFormat = "dd/MM/yyyy";
        public static class BookConstants
        {
            //Title
            public const int BookTitleMaxLength = 100;

            //Author
            public const int BookAuthorMinLength = 4;
            public const int BookAuthorMaxLength = 70;

            //Description
            public const int BookDescriptionMinLength = 200;
            public const int BookDescriptionMaxLength = 5000;

            //Price
            public const double BookPriceMinValue = 0;
            public const double BookPriceMaxValue = 10000;

            //PublishingHouse
            public const int BookPublishingHouseMaxLength = 70;

            //YearPublished
            public const int BookYearPublishedMinRange = 1;

            //ImageUrl
            public const int BookImageUrlMinLength = 5;
            public const int BookImageUrlMaxLength = 200;
        }

        public static class GenreConstants
        {
            //Name
            public const int GenreNameMinLength = 3;
            public const int GenreNameMaxLength = 40;
        }

        public static class BookStoreConstants
        {
            //Name
            public const int BookStoreNameMaxLength = 100;

            //Location
            public const int BookStoreLocationMinLength = 10;
            public const int BookStoreLocationMaxLength = 100;

            //Contact
            public const string BookStoreContactRegex = @"^(?:\\+359\\d{9}|\\d{10})$";

            //ImageUrl
            public const int BookStoreImageUrlMinLength = 5;
            public const int BookStoreImageUrlMaxLength = 200;
        }

        public static class EventConstants
        {
            public const string DateTimeEventFormat = "dd/MM/yyyy HH:mm";

            //Topic
            public const int EventTopicMinLength = 10;
            public const int EventTopicMaxLength = 100;

            //Description
            public const int EventDescriptionMinLength = 50;
            public const int EventDescriptionMaxLength = 500;

            //Location
            public const int EventLocationMinLength = 10;
            public const int EventLocationMaxLength = 100;

            //ImageUrl
            public const int EventImageUrlMinLength = 5;
            public const int EventImageUrlMaxLength = 200;
        }

        public static class ArticleConstants
        {
            //Title
            public const int ArticleTitleMinLength = 5;
            public const int ArticleTitleMaxLength = 100;

            //Content
            public const int ArticleContentMinLength = 100;
            public const int ArticleContentMaxLength = 2000;

            //ImageUrl
            public const int ArticleImageUrlMinLength = 5;
            public const int ArticleImageUrlMaxLength = 200;
        }
    }
}
