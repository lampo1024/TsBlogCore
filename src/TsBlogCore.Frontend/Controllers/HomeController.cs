using Microsoft.AspNetCore.Mvc;
using TsBlogCore.Repositories;

namespace TsBlogCore.Frontend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var post = new PostRepository().Read();
            return View(post);
        }
    }
}