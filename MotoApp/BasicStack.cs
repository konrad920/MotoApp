namespace MotoApp
{
    internal class BasicStack<T>//<T> oznaczenie generyczności, parametr T odpowiada za typ zmiennych w klasie
    {
        private readonly T[] _items;

        private int _courentIndeks = -1;

        public BasicStack()
        {
            _items = new T[10];
        }

        //public int Count 
        //{
        //    get 
        //    { 
        //        return _courentIndeks + 1;
        //    }
        //}

        public int Count => _courentIndeks + 1;//skrócony zapis propercji Count

        //public void Push(T item)
        //{
        //    _items[++_courentIndeks] = item;
        //}

        public void Push(T item) => _items[++_courentIndeks] = item;//skrócony zapis metody Push

        public T Pop() => _items[_courentIndeks--];
    }
}
