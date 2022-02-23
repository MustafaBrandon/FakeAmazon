using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TheAmazon.Models;
using TheAmazon.Models.ViewModels;

namespace TheAmazon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //private BookstoreContext context { get; set; }
        private IBookstoreRepository repo;

        //public HomeController(BookstoreContext temp)
        //{
        //    context = temp;
        //}

        public HomeController(IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string category, int pageNum = 1)
        {
            int resultsPerPage = 10;

            var x = new BookViewModel
            {
                Books = repo.Books
                .Where(p => p.Category == category || category == null)
                .OrderBy(p => p.BookId)
                .Skip((pageNum - 1) * resultsPerPage)
                .Take(resultsPerPage),
                PageInfo = new PageInfo
                {
                    TotalNumBooks = (category == null? repo.Books.Count() : repo.Books.Where(x => x.Category == category).Count()),
                    BooksPerPage = resultsPerPage,
                    CurrentPage = pageNum
                }
        };
            return View(x);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
