using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3VT25.Properties
{
    public class FoodItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ListManager<string> Ingredients { get; set; } = new ListManager<string>();

        public FoodItem(int id, string name)
        {
            ID = id;
            Name = name;
            Ingredients = new ListManager<string>();
        }

        public override string ToString()
        {
            return $"{ID}: {Name} - Ingredients: {string.Join(", ", Ingredients.ToStringList())}";
        }
    }
}
