using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Api
{
    public class EventApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}