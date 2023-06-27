namespace aula20_as
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Emprestado { get; set; } 
        public ICollection<LivroAutor> Autores { get; set; }
    }
}