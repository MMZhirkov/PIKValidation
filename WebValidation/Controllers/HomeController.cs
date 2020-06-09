using System.ServiceModel;
using System.Web.Mvc;

namespace WebValidation.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //try
            //{
            //    //var authClient = new ServiceReference1.AuthServiceClient();
            //    //var res = authClient.CheckLogin(new BaseRequest() { Login = "pikuser" });
            //    using (var authClient = new ServiceReference1.AuthServiceClient())
            //    {
            //        authClient.Open();
            //        if (authClient.State == CommunicationState.Faulted)
            //        {
            //            authClient.Abort();
             
            //        }


            //        var res = authClient.CheckLogin(new BaseRequest() { Login = "pikuser" });
            //    }
            //}
            //catch (System.Exception ex)
            //{

            //    throw;
            //}
           

            return View();
        }
    }
}
