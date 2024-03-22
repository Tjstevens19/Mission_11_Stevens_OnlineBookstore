using Microsoft.AspNetCore.Mvc;
using Mission_11_Stevens_OnlineBookstore.Models;
using Mission_11_Stevens_OnlineBookstore.Models.ViewModels;

namespace Mission_11_Stevens_OnlineBookstore.Controllers
{
    public class HomeController : Controller
    {
        private IOnlineBookstoreRepository _repository;
        public HomeController(IOnlineBookstoreRepository temp)
        {
            _repository = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var blah = new BookstoreListViewModel
            {
                Books = _repository.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repository.Books.Count()
                }
            };
            return View(blah);
        }
    }
}