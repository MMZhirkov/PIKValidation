using System.Web.Mvc;

namespace AuthWeb.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}