using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3VT25.Properties
{
    public interface IListManager<T>
    {
        int Count { get; }
        bool Add(T item);
        bool DeleteAt(int index);
        bool ChangeAt(T item, int index);
        T GetAt(int index);
        string[] ToStringArray();
        List<string> ToStringList();
        bool CheckIndex(int index);
        void DeleteAll();
    }
}
