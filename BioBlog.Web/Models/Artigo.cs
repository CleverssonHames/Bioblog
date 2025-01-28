namespace BioBlog.Web.Models;

public class Artigo
{
    public Guid Id { get; private set; }
    public string Titulo { get; private set; }
    public string Subtitulo { get; private set; }
    public string Texto { get; private set; }
    public string DataCriacao { get; private set; } 
    public string DataAlteracao { get; private set; }
    public Guid IdUsuario { get; private set; }

    public Artigo(string titulo, string subtitulo, string texto, Guid idUsuario)
    {
        Id = Guid.NewGuid();
        Titulo = titulo;
        Subtitulo = subtitulo;
        Texto = texto;
        IdUsuario = idUsuario;
    }

    public void UpdateArtigo(Guid id, string titulo, string subtitulo, string texto, Guid idUsuario)
    {
        
    }
}