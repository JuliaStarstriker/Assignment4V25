using Assignment4VT25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4VT25
{
    internal class Parrot : Bird
    {
        public string beakType;

        public int numberOfToes;
        private FoodSchedule foodSchedule;

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.eaterType = EaterType.Herbivore;
            foodSchedule.Add("Morning: fruits ");
            foodSchedule.Add("Lunch: Seeds & Nuts ");
            foodSchedule.Add("Evening: Vegetables ");
        }

        public string BeakType
        {
            get
            {
                return beakType;
            }
            set
            {
                beakType = value;
            }
        }

        public int NumberOfToes
        {
            get
            {
                return numberOfToes;
            }
            set
            {
                numberOfToes = value;
            }
        }
    }
}
