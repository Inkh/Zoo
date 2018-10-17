using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class TerrestrialMammal : Mammal
    {
        public virtual bool WalksWithFeet { get; set; } = true;

        /// <summary>
        /// How the animal runs
        /// </summary>
        /// <returns>Running animation and/or description</returns>
        public virtual string Run()
        {
            return "It runs super quick.";
        }
    }
}
