namespace CS2023
{
    public static class MyListTest
    {
        public static void Test()
        {
            MyList<string> names = new();
            names.Add("Liz");
            names.Add("Martha");
            names.Add("Beth");
            Console.WriteLine(names);
            for (int i = 0; i < names.Count; i++)
            {
                string s = names[i];
                names[i] = s.ToUpper();
            }
            Console.WriteLine(names);
            EventExample.Usage();

            MyList<int> a = new();
            a.Add(1);
            a.Add(2);
            MyList<int> b = new();
            b.Add(1);
            b.Add(2);
            Console.WriteLine(a == b);  // Outputs "True"
            b.Add(3);
            Console.WriteLine(a == b);  // Outputs "False"
        }
    }
    public class MyList<T>
    {
        const int DefaultCapacity = 4;

        T[] _items;
        int _count;

        public MyList(int capacity = DefaultCapacity)
        {
            _items = new T[capacity];
        }

        public int Count => _count;

        public int Capacity
        {
            get => _items.Length;
            set
            {
                if (value < _count) value = _count;
                if (value != _items.Length)
                {
                    T[] newItems = new T[value];
                    Array.Copy(_items, 0, newItems, 0, _count);
                    _items = newItems;
                }
            }
        }

        public T this[int index]
        {
            get => _items[index];
            set
            {
                if (!object.Equals(_items[index], value))
                {
                    _items[index] = value;
                    OnChanged();
                }
            }
        }

        public void Add(T item)
        {
            if (_count == Capacity) Capacity = _count * 2;
            _items[_count] = item;
            _count++;
            OnChanged();
        }
        protected virtual void OnChanged() =>
            Changed?.Invoke(this, EventArgs.Empty);

        public override bool Equals(object? other) =>
            Equals(this, other as MyList<T>);

        static bool Equals(MyList<T> a, MyList<T>? b)
        {
            if (a is null) return b is null;
            if (b is null || a._count != b._count)
                return false;
            for (int i = 0; i < a._count; i++)
            {
                if (!object.Equals(a._items[i], b._items[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public event EventHandler? Changed;

        public static bool operator ==(MyList<T> a, MyList<T> b) =>
            Equals(a, b);

        public static bool operator !=(MyList<T> a, MyList<T> b) =>
            !Equals(a, b);

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            string result = string.Empty;
            foreach (var item in _items)
            {
                result += item?.ToString() + ",";
            }
            return result.Trim(',');
        }
    }
    class EventExample
    {
        static int s_changeCount;

        static void ListChanged(object? sender, EventArgs e)
        {
            s_changeCount++;
        }

        public static void Usage()
        {
            var names = new MyList<string>();
            names.Changed += new EventHandler(ListChanged);
            names.Add("Liz");
            names.Add("Martha");
            names.Add("Beth");
            Console.WriteLine(s_changeCount); // "3"
        }
    }
}
