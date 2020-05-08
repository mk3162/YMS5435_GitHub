using System.Web.Mvc;

namespace YMS5435_GitHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string a = "sfdfsdf";
            int x = 345;
            char c = 'g';
            double sayi = 7.8;
            double sayi2 = 65.5;
            return View();
        }
    }
}