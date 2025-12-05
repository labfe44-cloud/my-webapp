using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Admin
{
    public class AdminMapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}