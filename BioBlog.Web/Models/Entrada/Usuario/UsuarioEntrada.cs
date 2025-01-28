using System.ComponentModel.DataAnnotations;

namespace BioBlog.Web.Models.Entrada.Usuario;

public class UsuarioEntrada
{
    [Required(ErrorMessage = "O nome é obrigatório!")]
    public string Nome { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "E-mail é obrigatório!")]
    [StringLength(maximumLength: 50, MinimumLength = 10, ErrorMessage = "Valor informado invalido para o campo!")]
    public string Email { get; set; } = string.Empty;
    [Required(ErrorMessage = "Senha é obrigatória!")]
    public string Senha { get; set; } = string.Empty;
}