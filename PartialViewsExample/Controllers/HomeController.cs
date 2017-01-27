using System.Web.Mvc;
using PartialViewsExample.Models;

namespace PartialViewsExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var homeViewModel = new HomePageViewModel();
            return View(homeViewModel);
        }
    }
}