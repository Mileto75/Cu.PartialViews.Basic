using Microsoft.AspNetCore.Mvc;

namespace Cu.Views.Web.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["PageTitle"] = "Games";
            ViewBag.PageTitle = "Games";
            return View();
        }
    }
}
