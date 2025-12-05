using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}