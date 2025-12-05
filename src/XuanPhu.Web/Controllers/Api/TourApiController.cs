using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Api
{
    public class TourApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}