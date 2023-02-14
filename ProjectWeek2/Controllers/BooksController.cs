using ProjectWeek2.Models.ViewModel;
using System.Web.Mvc;

namespace ProjectWeek2.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
          
        public ActionResult Index()
        {
            Book book = new Book();
            return View(book.GetListbooks());
        }
    }
}