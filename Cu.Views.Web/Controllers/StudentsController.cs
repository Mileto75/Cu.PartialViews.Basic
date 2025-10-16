using Microsoft.AspNetCore.Mvc;

namespace Cu.Views.Web.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
