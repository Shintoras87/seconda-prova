using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Detail(string id)
        {
            return View();
        }


    }
}