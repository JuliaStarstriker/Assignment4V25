using Assignment4VT25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4VT25
{
    public class FoodSchedule
    {
        List<string> foodList = new List<string>();
        
        public string Description { get; set; }
    
        public int Count => foodList.Count;

        private EaterType _eaterType;

        public EaterType eaterType
        {
            get { return _eaterType; }
            set
            {
                // you can add validation or logic here if needed
                _eaterType = value;
            }
        }

        public FoodSchedule()
        {
            foodList = new List<string>();
        }
        public List<string> GetFoodSchedule()
        {
            return foodList;
        }

        public void Add(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                foodList.Add(item);
            }
        }

        public bool ChangeAt(int index, string item)
        {
            if (CheckIndex(index) && !string.IsNullOrEmpty(item))
            {
                foodList[index] = item;
                return true;
            }
            return false;
        }

        public bool CheckIndex(int index)
        {
            return index >= 0 && index < foodList.Count;
        }

        public bool DeleteAt(int index)
        {
            if (CheckIndex(index))
            {
                foodList.RemoveAt(index);
                return true;
            }
            return false;
        }

        public string[] GetFoodListInfoStrings()
        {
            string[] infoStrings = foodList.ToArray();
            return infoStrings;
        }

        public string Title()
        {
            return "Food Schedule";
        }

        public override string ToString()
        {
            return $"Eater Type: {eaterType}, Food Count: {Count}";
        }
    }
}
