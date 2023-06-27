using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace aula20_as
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly IAutorService _autorService;
        private readonly ILivroService _livroService;
        private readonly IMapper _mapper;

        public AutorController(IAutorService autorService, ILivroService livroService, IMapper mapper)
        {
            _autorService = autorService;
            _livroService = livroService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllAutores()
        {
            var autores = _autorService.GetAllAutores();
            var autorDTOs = _mapper.Map<List<AutorDTO>>(autores);
            return Ok(autorDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetAutorById(int id)
        {
            var autor = _autorService.GetAutorById(id);
            if (autor == null)
                return NotFound();

            var autorDTO = _mapper.Map<AutorDTO>(autor);
            return Ok(autorDTO);
        }

        [HttpPost]
        public IActionResult CreateAutor([FromBody] AutorDTO autorDTO)
        {
            var autor = _mapper.Map<Autor>(autorDTO);
            _autorService.CreateAutor(autor);

            return Ok(new
            {
                StatusCode = 200,
                Message = "Autor cadastrado com sucesso!",
                autor
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAutor(int id, [FromBody] AutorDTO autorDTO)
        {
            var autor = _mapper.Map<Autor>(autorDTO);
            autor.Id = id;
            _autorService.UpdateAutor(autor);

            return Ok(new
            {
                StatusCode = 200,
                Message = "Autor atualizado com sucesso!",
                autor
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAutor(int id)
        {
            _autorService.DeleteAutor(id);

            return Ok(new
            {
                StatusCode = 200,
                Message = "Autor deletado com sucesso!"
            });
        }
    }
}
