using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    }
}
