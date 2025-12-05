using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Admin
{
    public class AdminEventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}