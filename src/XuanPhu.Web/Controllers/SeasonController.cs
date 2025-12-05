using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers
{
    public class SeasonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}