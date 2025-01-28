using BioBlog.Web.Models;
using BioBlog.Web.Models.Entrada.Usuario;

namespace BioBlog.Web.Services;

public interface IUsuarioService
{
    Task<Usuario> Autenticar(LoginEntrada login);
    Task<Usuario> AddUsuario(UsuarioEntrada usuario);

    Task<Usuario> GetUsuaruio(Guid id);
}