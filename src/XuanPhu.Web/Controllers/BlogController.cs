using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}