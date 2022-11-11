using ProjectKonsentrasi.Helper.Extension;
using ProjectKonsentrasi.Webserver.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace ProjectKonsentrasi.Webserver.Controllers;
public class DashboardController : Controller
{
    [HttpGet("dashboard")]
    public IActionResult Index()
    {
        ViewData["User"] = HttpContext.Session.Get<AuthCookie>("Login")!.Nama;
        return View();
    }
}
