using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4VT25
{
    public abstract class Fish : Animal
    {
        public string scaleColor;
        public bool isSaltwater;

        public string ScaleColor
        {
            get
            {
                return scaleColor;
            }
            set
            {
                scaleColor = value;
            }
        }

        public bool IsSaltwater
        {
            get
            {
                return isSaltwater;
            }
            set
            {
                isSaltwater = value;
            }
        }

    }
}
