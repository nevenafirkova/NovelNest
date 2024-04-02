﻿namespace NovelNest.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using NovelNest.Attributes;
    using NovelNest.Core.Contracts;
    using NovelNest.Core.Extensions;
    using NovelNest.Core.Models.QueryModels.BookStore;
    using NovelNest.Core.Models.ViewModels.Article;
    using NovelNest.Core.Models.ViewModels.BookStore;
    using NovelNest.Core.Services;
    using System.Security.Claims;

    public class BookStoreController : BaseController
    {
        private readonly IBookStoreService bookStoreService;
        private readonly IPublisherService publisherService;

        public BookStoreController(IBookStoreService bookStoreService, IPublisherService publisherService)
        {
            this.bookStoreService = bookStoreService;
            this.publisherService = publisherService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllBookStoresQueryModel model)
        {
            var allEvents = await bookStoreService.AllAsync(
                model.SearchTerm,
                model.Status,
                model.CurrentPage,
                model.BookStoresPerPage);

            model.TotalBookStoresCount = allEvents.TotalBookStoresCount;
            model.BookStores = allEvents.BookStores;

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id, string information)
        {
            if (!await bookStoreService.BookStoreExistsAsync(id))
            {
                return BadRequest();
            }

            var currentBookStore = await bookStoreService.DetailsAsync(id);

            if (information != currentBookStore.GetInformation())
            {
                return BadRequest();
            }

            return View(currentBookStore);
        }

        [HttpGet]
        [MustBePublisher]
        public async Task<IActionResult> Add()
        {
            if (await publisherService.ExistsByIdAsync(User.Id()) == false)
            {
                return Unauthorized();
            }

            var bookStoreForm = new BookStoreAddViewModel();

            return View(bookStoreForm);
        }

        [HttpPost]
        [MustBePublisher]
        public async Task<IActionResult> Add(BookStoreAddViewModel bookStoreForm)
        {
            if (!ModelState.IsValid)
            {
                return View(bookStoreForm);
            }

            await bookStoreService.AddAsync(bookStoreForm);
            return RedirectToAction(nameof(All));
        }
    }
}