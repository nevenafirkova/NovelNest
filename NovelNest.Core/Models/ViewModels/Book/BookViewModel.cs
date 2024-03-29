﻿using NovelNest.Core.Contracts;
using NovelNest.Infrastructure.Data.Models.Books;

namespace NovelNest.Core.Models.ViewModels.Book
{
    public class BookViewModel : IBookModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Author { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int Pages { get; set; }

        public string PublishingHouse { get; set; } = null!;

        public int YearPublished { get; set; }

        public string CoverType { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public List<BookReview> Reviews = new List<BookReview>();
    }
}