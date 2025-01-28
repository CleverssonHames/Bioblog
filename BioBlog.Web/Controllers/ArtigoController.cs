using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BioBlog.Web.Controllers;

[Authorize]
public class ArtigoController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}