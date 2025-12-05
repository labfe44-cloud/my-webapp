using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}