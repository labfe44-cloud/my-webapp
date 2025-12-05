using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Admin
{
    public class AdminEducationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}