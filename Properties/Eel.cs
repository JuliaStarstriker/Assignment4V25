using Assignment2VT25.Assignment2V25;
using Assignment2VT25.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VT25.Properties
{
    internal class Eel : Fish
    {
        public bool isElectric;
        public int maxLength;
        private FoodSchedule foodSchedule;

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: Fish ");
            foodSchedule.Add("Lunch: Crustaceans ");
            foodSchedule.Add("Evening: Worms & Insects");
        }

        public bool IsElectric
        {
            get
            {
                return isElectric;
            }
            set
            {
                isElectric = value;
            }
        }

        public int MaxLength
        {
            get
            {
                return maxLength;
            }
            set
            {
                maxLength = value;
            }
        }
    }
}
