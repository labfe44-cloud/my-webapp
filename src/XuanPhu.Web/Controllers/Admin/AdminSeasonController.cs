using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Admin
{
    public class AdminSeasonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}