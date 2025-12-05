using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}