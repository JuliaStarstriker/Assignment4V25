using Assignment4VT25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4VT25
{
    internal class MonkFish : Fish
    {
        public bool hasAnglerLight;
        public string habitatDepth;
        private FoodSchedule foodSchedule;

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.eaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: Fish ");
            foodSchedule.Add("Lunch: Crustaceans ");
            foodSchedule.Add("Evening: Squid & Octopus");
        }

        public bool HasAnglerLight
        {
            get
            {
                return hasAnglerLight;
            }
            set
            {
                hasAnglerLight = value;
            }
        }

        public string HabitatDepth
        {
            get
            {
                return habitatDepth;
            }
            set
            {
                habitatDepth = value;
            }
        }
        
    }
}
