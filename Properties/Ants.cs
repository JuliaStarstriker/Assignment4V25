using Assignment2VT25.Assignment2V25;
using Assignment2VT25.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VT25.Properties
{
    internal class Ants : Insect
    {
        private FoodSchedule foodSchedule;
        

        public int lifespanIndays;
        public string neckStrength;

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: seeds");
            foodSchedule.Add("Lunch: fungi");
            foodSchedule.Add("Evening: other insects");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }

        public int LifespanIndays
        {
            get
            {
                return lifespanIndays;
            }
            set
            {
                lifespanIndays = value;
            }
        }
        public string NeckStrength
        {
            get
            {
                return neckStrength;
            }
            set
            {
                neckStrength = value;
            }
        }
    }
}
