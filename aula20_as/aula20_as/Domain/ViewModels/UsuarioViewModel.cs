namespace aula20_as.Domain.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Livro> LivrosEmprestados { get; set; }
    }
}