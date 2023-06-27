namespace aula20_as.Domain.DTOs
{
    public class LivroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Emprestado { get; set; } 
        public List<int> AutoresIds { get; set; }
    }
}