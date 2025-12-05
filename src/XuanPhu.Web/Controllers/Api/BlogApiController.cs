using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Api
{
    public class BlogApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}