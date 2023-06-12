using Aula12_TestandoORM.Data.Repositories;
using Aula12_TestandoORM.Domain.Interfaces;
using Aula12_TestandoORM.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Aula12_TestandoORM.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstacionamentoController : ControllerBase
    {
        private readonly IEstacionamentoRepository repository;

        public EstacionamentoController()
        {
            this.repository = new EstacionamentoRepository();
        }

        [HttpGet]
        public IEnumerable<Estacionamento> Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Estacionamento Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Estacionamento item)
        {
            repository.Save(item);
            return Ok(new
            {
                StatusCode = 200,
                message = "Estacionamento cadastrado com sucesso!",
                item
            });
        }

        [HttpPut]
        public IActionResult Put([FromBody] Estacionamento item)
        {
            repository.Update(item);
            return Ok(new
            {
                StatusCode = 200,
                message = "Estacionamento tualizado com sucesso!",
                item
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok(new
            {
                StatusCode = 200,
                message = "Estacionamento deletado com sucesso!"
            });
        }
    }
}