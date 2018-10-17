using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Animal
    {
        public abstract string SizeOfBaby { get; set; }
        public abstract bool BreatheOnLand { get; set; }
        public virtual int NumberOfLimbs { get; set; } = 4;
    }
}
