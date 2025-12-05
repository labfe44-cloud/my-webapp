using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Api
{
    public class MapApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}