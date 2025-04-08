using Assignment2VT25.Assignment2V25;
using Assignment2VT25.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VT25.Properties
{
    public class Eagles : Bird
    {
        public string huntingSkill;
        public float flyingSpeed;
        private FoodSchedule foodSchedule;
        public override FoodSchedule GetFoodSchedule()  
        {
            return foodSchedule;
        }

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Carnivore;
            foodSchedule.Add("Morning: Small mammals");
            foodSchedule.Add("Lunch: Fish ");
            foodSchedule.Add("Evening: Small birds ");
        }

        public string HuntingSkill
        {
            get
            {
                return huntingSkill;
            }
            set
            {
                huntingSkill = value;
            }
        }

        public float FlyingSpeed
        {
            get
            {
                return flyingSpeed;
            }
            set
            {
                flyingSpeed = value;
            }
        }
    }
}
