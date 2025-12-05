using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers.Admin
{
    public class AdminTourController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}