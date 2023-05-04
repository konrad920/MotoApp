using MotoApp.Entities;

namespace MotoApp.Repositories
{
    public class GenericRepository <TEntity, TKey> //parametrów generycznych moze byc wiecej niz jeden i kazdy moze miec swoje ograniczenie
        where TEntity : class, IEntity, new()//ograniczenie where czyli parametr generyczny T musi być klasą, implementować po interfejsie
        where TKey : struct//struct to typ nienulowy(bez null) wartosciowy
    {//ograniczenie new() oznacza ze typ z którego bedziemy korzystac musi miec bezparametrowy konstruktor
        public TKey? Key { get; set; }

        protected readonly List<TEntity> _items = new();

        public void Add(TEntity item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void Remove(TEntity item)
        {
            _items.Remove(item);
        }

        public TEntity GetById(int id)
        {
            return null;
            //return _items.Single(item => item.Id == id);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
