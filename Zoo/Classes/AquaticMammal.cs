using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class AquaticMammal : Mammal
    {
        public abstract bool HasGill { get; set; }
        public virtual bool WithStandHighPressure { get; set; }
    }
}
