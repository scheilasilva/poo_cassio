using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.Interfaces;

namespace Aula12_TestandoORM.Data.Repositories
{
    public class EstacionamentoRepository : IEstacionamentoRepository
    {
        private readonly MeuContexto context;

        public EstacionamentoRepository(MeuContexto context)
        {
            this.context = context;
        }

        public IList<Estacionamento> GetAll()
        {
            return context.Estacionamentos.ToList();
        }

        public Estacionamento GetById(int entityId)
        {
            return context.Estacionamentos.SingleOrDefault(x => x.Id == entityId);
        }

        public void Save(Estacionamento entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Estacionamento entity)
        {
            context.Estacionamentos.Update(entity);
            context.SaveChanges();
        }

        public void Delete(int entityId)
        {
            var c = GetById(entityId);
            context.Estacionamentos.Remove(c);
            context.SaveChanges();
        }

    }
}