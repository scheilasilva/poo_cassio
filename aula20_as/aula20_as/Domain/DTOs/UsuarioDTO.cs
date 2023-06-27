using aula20_as.Domain.DTOs;

namespace aula20_as
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<LivroDTO> LivrosEmprestados { get; set; }
    }

}
