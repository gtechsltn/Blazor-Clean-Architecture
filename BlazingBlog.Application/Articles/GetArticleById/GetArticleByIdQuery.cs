﻿namespace BlazorCleanArchitecture.Application.Articles.GetArticleById
{
    public class GetArticleByIdQuery : IQuery<ArticleDto?>
    {
        public int Id { get; set; }
    }
}
