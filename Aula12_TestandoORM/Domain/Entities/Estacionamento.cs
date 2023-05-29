namespace Aula12_TestandoORM.Domain.Entities
{
    public class Estacionamento
    {
        public int Id { get; set; }
        public List<Carro> Carro { get; set; }
    }
}