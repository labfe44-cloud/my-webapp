using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Admin
{
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
