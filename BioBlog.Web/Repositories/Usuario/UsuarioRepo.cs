using BioBlog.Web.Models.Entrada.Usuario;
using BioBlog.Web.Repositories.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace BioBlog.Web.Repositories.Usuario;

public class UsuarioRepo : IUsuarioRepo
{
    private readonly AppDbContext _DbContext;

    public UsuarioRepo(AppDbContext DbContext)
    {
        _DbContext = DbContext;
    }
    public async Task<Models.Usuario> Autenticar(LoginEntrada login)
    {
        var usuario = await _DbContext.Usuarios.Where(x => x.Email.Equals(login.Email) && x.Senha.Equals(login.Senha)).SingleOrDefaultAsync();
        if (string.IsNullOrWhiteSpace(usuario.Email))
        {
            return new Models.Usuario(string.Empty, String.Empty, String.Empty);
        }
        return usuario;
    }

    public async Task<Models.Usuario> AddUsuario(UsuarioEntrada usuario)
    {
        var newUser = new Models.Usuario(usuario.Nome, usuario.Email, usuario.Senha);
        await _DbContext.Usuarios.AddAsync(newUser);
        await _DbContext.SaveChangesAsync();
        return newUser;

    }

    public async Task<Models.Usuario> GetUsuario(Guid id)
    {
        var usuario = await _DbContext.Usuarios.SingleOrDefaultAsync(x => x.Id.Equals(id));
        if (string.IsNullOrWhiteSpace(usuario.Email))
        {
            return new Models.Usuario(String.Empty, string.Empty, string.Empty);
        }
        return usuario;
    }
}