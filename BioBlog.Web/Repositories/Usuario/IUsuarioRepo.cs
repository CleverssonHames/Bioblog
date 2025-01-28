using BioBlog.Web.Models.Entrada.Usuario;

namespace BioBlog.Web.Repositories.Usuario;

public interface IUsuarioRepo
{
    Task<Models.Usuario> Autenticar(LoginEntrada login);
    Task<Models.Usuario> AddUsuario(UsuarioEntrada usuario);
    Task<Models.Usuario> GetUsuario(Guid id);
}