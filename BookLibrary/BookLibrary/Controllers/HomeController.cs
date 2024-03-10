using BookLibrary.Models;
using Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBooksServices _booksServices;

        private readonly ILogger<HomeController> _logger;

        public HomeController(IBooksServices booksServices, ILogger<HomeController> logger)
        {
            _booksServices = booksServices;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new BooksViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Search(string searchBy, string searchTerm)
        {

            var books = await _booksServices.GetBooksByTerms(searchBy, searchTerm);

            var model = new BooksViewModel();

             model.listBooks = (List<Domain.Model.BooksDto>)books;

            return View("Index",model); 
        
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
