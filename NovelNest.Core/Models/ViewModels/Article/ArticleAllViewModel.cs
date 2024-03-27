﻿using NovelNest.Core.Contracts;

namespace NovelNest.Core.Models.ViewModels.Article
{
    public class ArticleAllViewModel : IArticleModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime DatePublished { get; set; }
        public string ImageUrl { get; set; } = null!;
        public int ViewsCount { get; set; }
    }
}