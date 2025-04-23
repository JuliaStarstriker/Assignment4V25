using Assignment4VT25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4VT25
{
    internal class Butterflies : Insect
    {
        public bool hasWings { get; set; }
        public string wingPattern { get; set; }

        private FoodSchedule foodSchedule;

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }
        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule()
            {
                eaterType = EaterType.Herbivore
            };
            foodSchedule.Add("Morning: Nectar ");
            foodSchedule.Add("Lunch: Fruit ");
            foodSchedule.Add("Evening: Tree Sap");      
        }

        public bool HasWings
        {
            get
            {
                return hasWings;
            }
            set
            {
                hasWings = value;
            }
        }

        public string WingPattern
        {
            get
            {
                return wingPattern;
            }
            set
            {
                wingPattern = value;
            }
        }
    }
}
