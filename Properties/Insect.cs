using Assignment2VT25.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VT25.Properties
{
    public abstract class Insect : Animal
    {
        public string antennaType;
        public int numberOfLegs;


        public string AntennaType
        {
            get
            {
                return antennaType;
            }
            set
            {
                antennaType = value;
            }
        }

        public int NumberOfLegs
        {
            get
            {
                return numberOfLegs;
            }
            set
            {
                numberOfLegs = value;
            }
        }
    }
}
