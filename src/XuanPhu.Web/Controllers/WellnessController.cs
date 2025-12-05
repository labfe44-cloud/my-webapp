using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers
{
    public class WellnessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}