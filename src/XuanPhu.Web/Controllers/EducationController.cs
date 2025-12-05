using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers
{
    public class EducationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}