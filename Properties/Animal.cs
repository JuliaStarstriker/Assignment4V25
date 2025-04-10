using Assignment2VT25.Assignment2V25;
using Assignment2VT25.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VT25.Properties
{
    public abstract class Animal : IAnimal
    {
        public string name { get; set; }
        public string Id { get; set; }
        public int age { get; set; }
        public GenderType gender { get; set; }
        public Category Category { get; set; }
        public Species species { get; set; }
       
        /// <summary>
        /// The implementation of this method is to be provided by the subclasses.
        /// The information is not available and therefore the job is delegated to subclasses
        /// </summary>
        /// <returns>An object of the FoodScheduled assigned to the particular object.</returns>
        public abstract FoodSchedule GetFoodSchedule();

        /// <summary>
        /// prepare a string made of the specifications that are not included in the Animal class.
        /// A default implementation is coded in this method
        /// </summary>
        /// <returns></returns>
        public virtual string GetExtraInfo()
        {
            string strout = string.Empty;

            strout = string.Format("{0,-15} {1,10}\n", "category:", Category.ToString());

            return strout;
        }

        public override string ToString()
        {
            return $"{Id}, {name}, {age}, {gender}, {species}";
        }
    }
}
