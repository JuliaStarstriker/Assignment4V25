using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3VT25.Properties
{
    public class ListManager<T> : IListManager<T>
    {
        private List<T> _items;

        public ListManager()
        {
            _items = new List<T>();
        }

        public int Count => _items.Count;

        public bool Add(T item)
        {
            if (item == null)
            {
                return false;
            }
            _items.Add(item);
            return true;
        }

        public bool DeleteAt(int index)
        {
            if (!CheckIndex(index))
            {
                return false;
            }
            _items.RemoveAt(index);
            return true;
        }

        public bool ChangeAt(T item, int index)
        {
            if (item == null || !CheckIndex(index))
            {
                return false;
            }
            _items[index] = item;
            return true;
        }

        public T GetAt(int index)
        {
            if (!CheckIndex(index))
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            return _items[index];
        }

        public string[] ToStringArray()
        {
            return _items.ConvertAll(item => item.ToString()).ToArray();
        }

        public List<string> ToStringList()
        {
            return _items.ConvertAll(item => item.ToString());
        }

        public bool CheckIndex(int index)
        {
            return index >= 0 && index < _items.Count;
        }

        public void DeleteAll()
        {
            _items.Clear();
        }
    }
}
