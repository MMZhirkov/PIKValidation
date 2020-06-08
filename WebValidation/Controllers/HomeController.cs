using System.Web.Mvc;
using WebValidation.AuthService;

namespace WebValidation.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var authClient = new AuthService.AuthServiceClient())
            {
                var res = authClient.CheckLogin(new BaseRequest() { Login = "pikuser" });
            }

            return View();
        }
    }
}
