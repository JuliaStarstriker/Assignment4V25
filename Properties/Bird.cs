using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VT25.Properties
{
    public abstract class Bird : Animal
    {
        private string feathers_color;
        private float wingspan;

        public string Feathers_color
        {
            get
            {
                return feathers_color;
            }
            set
            {
                feathers_color = value;
            }
        }

        public float Wingspan
        {
            get
            {
                return wingspan;
            }
            set
            {
                wingspan = value;
            }
        }
    }
}
