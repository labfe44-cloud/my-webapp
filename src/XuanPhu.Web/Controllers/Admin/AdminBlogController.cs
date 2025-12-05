using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Admin
{
    public class AdminBlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}