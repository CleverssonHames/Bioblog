namespace BioBlog.Web.Models.Entrada.Usuario;

public class LoginEntrada
{
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string ReturnUrl { get; set; } = string.Empty;
    
    public bool RememberMe { get; set; }
}