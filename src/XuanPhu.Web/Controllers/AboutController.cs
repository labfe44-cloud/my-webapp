using Microsoft.AspNetCore.Mvc;

namespace XuanPhu.Web.Controllers
{
    public class AboutController : Controller
    {
public IActionResult Index() => View();

    public IActionResult Introduction() => View();
    }
}