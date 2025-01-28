using System.Security.Claims;
using BioBlog.Web.Models;
using BioBlog.Web.Models.Entrada.Usuario;
using BioBlog.Web.Services;
using BioBlog.Web.Services.Artigo;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace BioBlog.Web.Controllers;

public class UsuarioController : Controller
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromForm] LoginEntrada login)
    {
        var usuarioLogado = await _usuarioService.Autenticar(login);

        if (string.IsNullOrWhiteSpace(usuarioLogado.Nome))
        {
            ViewBag.Fail = true;
            return View("Index");
        }
        
        List<Claim> claims =
        [
            new Claim(ClaimTypes.NameIdentifier, usuarioLogado.Id.ToString()),
            new Claim(ClaimTypes.Name, usuarioLogado.Nome)
        ];

        var authScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        var identity = new ClaimsIdentity(claims, authScheme);
        var principal = new ClaimsPrincipal(identity);

        await HttpContext.SignInAsync(authScheme, principal,
            new AuthenticationProperties()
            {
                IsPersistent = true //login.RememberMe
            });

        // if (!string.IsNullOrWhiteSpace(login.ReturnUrl))
        //     return Redirect(login.ReturnUrl);
        
        return RedirectToRoute("Artigo.Index");
    }

    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync();
        return RedirectToRoute("Usuario.Index");
    }

    public IActionResult AddUsuario()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddUsuario(UsuarioEntrada usuario)
    {
        if (ModelState.IsValid)
        {
            var result = await _usuarioService.AddUsuario(usuario);
            return RedirectToRoute("Usuario.Index");
        }
        
        return View(usuario);
    }
}