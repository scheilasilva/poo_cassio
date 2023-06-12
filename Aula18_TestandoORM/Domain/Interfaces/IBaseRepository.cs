namespace Aula12_TestandoORM.Domain.Interfaces
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        Entity GetById(int entityId);
        IList<Entity> GetAll();
        void Save(Entity entity);
        void Update(Entity entity);
        void Delete(int entityId);
    }
}