namespace WebApiProjeto.Models;

public class LivroModel
{
    public int id { get; set; }
    
    public string Titulo { get; set; }
    
    public AutorModel Autor { get; set; }
}