using MotoApp.Entities;

namespace MotoApp.Repositories
{
    public class GenericRepositoryWithRemove<TEntity, TKey> : GenericRepository<TEntity, TKey> //przyklad dzieziczenia klasy generycznej
        where TEntity : class, IEntity, new()
        where TKey : struct
    {
        public void Remove(TEntity item)
        {
            _items.Remove(item);
        }
    }
}
