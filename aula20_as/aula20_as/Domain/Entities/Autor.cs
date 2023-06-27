namespace aula20_as
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<LivroAutor> Livros { get; set; }
    }
}
