using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class AquaticMammal : Mammal, ISwim
    {
        public abstract bool HasGill { get; set; }
        public virtual bool WithStandHighPressure { get; set; }
        public virtual bool SurviveUnderWater { get; set; } = true;

        public virtual string Swim()
        {
            return "The mammal swims";
        } 
    }
}
