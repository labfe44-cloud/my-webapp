using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers
{
    public class TourController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}