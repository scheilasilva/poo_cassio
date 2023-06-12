using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.Interfaces;

namespace Aula12_TestandoORM.Data.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private readonly MeuContexto context;

        public CarroRepository()
        {
            this.context = new MeuContexto();
        }
        
        public IList<Carro> GetAll()
        {
            return context.Carros.ToList();
        }

        public Carro GetById(int entityId)
        {
            return context.Carros.SingleOrDefault(x => x.Id == entityId);
        }

        public void Save(Carro entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Carro entity)
        {
            context.Carros.Update(entity);
            context.SaveChanges();
        }

        public void Delete(int entityId)
        {
            var e = GetById(entityId);
            context.Carros.Remove(e);
            context.SaveChanges();
        }



    }
}