using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BioBlog.Web.Models;

public class Usuario
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Senha { get; private set; }
    
    public Usuario(string nome, string email, string senha)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Email = email;
        Senha = senha;
    }
    
    public void updatePassword(string senha)
    {
        Senha = senha;
    }
}