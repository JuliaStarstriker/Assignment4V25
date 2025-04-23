using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4VT25
{
    public class ListManager<T> : IListManager<T>
    {
        private List<T> _items;

        // Constructor: initializes the internal list
        public ListManager()
        {
            _items = new List<T>();
        }

        // Read-only property to get the number of items in the list
        public int Count => _items.Count;

        /// <summary>
        /// Adds an item to the list if it's not null
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Add(T item)
        {
            if (item == null)
            {
                return false;
            }
            _items.Add(item);
            return true;
        }

        /// <summary>
        /// Deletes an item at the specified index if the index is valid
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteAt(int index)
        {
            if (!CheckIndex(index))
            {
                return false;
            }
            _items.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// Replaces the item at the specified index with a new item, if both are valid
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeAt(T item, int index)
        {
            if (item == null || !CheckIndex(index))
            {
                return false;
            }
            _items[index] = item;
            return true;
        }

        /// <summary>
        /// Returns the item at the specified index, or throws an exception if index is invalid
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public T GetAt(int index)
        {
            if (!CheckIndex(index))
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            return _items[index];
        }

        /// <summary>
        /// Returns all items in the list as an array of strings
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray()
        {
            return _items.ConvertAll(item => item.ToString()).ToArray();
        }

        /// <summary>
        /// Returns all items in the list as a list of strings
        /// </summary>
        /// <returns></returns>
        public List<string> ToStringList()
        {
            return _items.ConvertAll(item => item.ToString());
        }

        /// <summary>
        /// Checks if a given index is within valid bounds of the list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            return index >= 0 && index < _items.Count;
        }

        /// <summary>
        /// Deletes all items from the list
        /// </summary>
        public void DeleteAll()
        {
            _items.Clear();
        }
    }
}
