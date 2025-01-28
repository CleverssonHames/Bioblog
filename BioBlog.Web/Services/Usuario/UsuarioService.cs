using BioBlog.Web.Models;
using BioBlog.Web.Models.Entrada.Usuario;
using BioBlog.Web.Repositories.Usuario;

namespace BioBlog.Web.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepo _usuarioRepo;

    public UsuarioService(IUsuarioRepo usuarioRepo)
    {
        _usuarioRepo = usuarioRepo;
    }
    public async Task<Usuario> Autenticar(LoginEntrada login)
    {
        // Em caso de erro no login
        if (string.IsNullOrWhiteSpace(login.Email) && string.IsNullOrWhiteSpace(login.Senha))
        {
            return new Models.Usuario(string.Empty, String.Empty, String.Empty);
        }
        var result = await _usuarioRepo.Autenticar(login);
        return result;
    }

    public async Task<Usuario> AddUsuario(UsuarioEntrada usuario)
    {
        if (string.IsNullOrWhiteSpace(usuario.Email) || string.IsNullOrWhiteSpace(usuario.Nome) ||
            string.IsNullOrWhiteSpace(usuario.Senha))
        {
            return new Models.Usuario(string.Empty, String.Empty, String.Empty);
        }
        var result = await _usuarioRepo.AddUsuario(usuario);
        return result;
    }

    public async Task<Usuario> GetUsuaruio(Guid id)
    {
        if (id == Guid.Empty)
        {
            return new Usuario(string.Empty, String.Empty, String.Empty);
        }
        var usuario = await _usuarioRepo.GetUsuario(id);
        return usuario;
    }
    
}